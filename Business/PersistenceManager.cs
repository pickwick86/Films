using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Configuration;

namespace Business
{
    public class PersistenceManager
    {
        #region Members

        private const string FILENAME = "Films.xml";

        private const string SOURCE_FILENAME = "Sources.xml";

        private readonly List<string> _extensions = new List<string>() { ".avi", ".mkv", ".mp4"};
        
        private XmlSerializer _serializer = new XmlSerializer(typeof(List<Film>));
        
        private XmlSerializer _sourceSerializer = new XmlSerializer(typeof(List<Source>));

        private List<Film> _catalogFilms;

        private List<Film> _folderFilms;

        private List<Source> _sources;

        private List<string> _genres;
                
        private static PersistenceManager _instance;

        #endregion

        #region Properties

        public static PersistenceManager Instance 
        { 
            get 
            {
                return _instance ?? (_instance = new PersistenceManager());
            } 
        }

        public Film[] Films { get { return _catalogFilms.ToArray(); } }

        public Film[] FolderFilms 
        { 
            get 
            {
                return string.IsNullOrEmpty(CurrentFilter) ? _folderFilms.ToArray() : _folderFilms.Where(x => MatchesFilter(x)).ToArray();
            } 
        }
        
        public Source SelectedSource { get; set; }

        public Source[] Sources { get { return _sources.ToArray(); } }

        public string CurrentFilter { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        private PersistenceManager()
        {
            CurrentFilter = string.Empty;

            if (File.Exists(SOURCE_FILENAME))
            {
                using (StreamReader reader = new StreamReader(SOURCE_FILENAME))
                {
                    _sources = (List<Source>)_sourceSerializer.Deserialize(reader);
                }
            }
            else
            {
                _sources = new List<Source>();
            }

            SelectedSource = _sources.SingleOrDefault(x => x.Name == ConfigurationSettings.AppSettings["SOURCE"]);

            string file = FILENAME;
            

            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    _catalogFilms = (List<Film>)_serializer.Deserialize(reader);
                }

            }
            else
            {
                _catalogFilms = new List<Film>();
            }
            ScanFolder();

            

            Save();

        }


        public string GetTitleFromFileName(string fileName)
        {
            if (fileName.StartsWith("N°"))
            {
                return Path.GetFileNameWithoutExtension(fileName).Split('-').Last().Trim();
            }
            else if(fileName.Contains(" ") || !Path.GetFileNameWithoutExtension(fileName).Contains("."))
            {
                return Path.GetFileNameWithoutExtension(fileName).Split('-').First().Trim();
            }
            else
            {
                string[] items = Path.GetFileNameWithoutExtension(fileName).Split('.');
                List<string> titleList = new List<string>();

                bool take = false;
                foreach(var item in items.Reverse())
                {
                    int year;
                    bool isYear = int.TryParse(item, out year) && year > 1000;
                    if(!take && isYear)
                    {
                        take = true;
                        continue;
                    }
                    if(take)
                    {
                        titleList.Add(item);
                    }
                }
                titleList.Reverse();
                return take ? string.Join(" ", titleList) : Path.GetFileNameWithoutExtension(fileName);
            }
        }

        #endregion

        #region Methods

        public void Save()
        {
            string file = Path.Combine(FILENAME);

            using (StreamWriter writer = new StreamWriter(file))
            {
                _serializer.Serialize(writer, _catalogFilms);
            }
        }

        public void ScanFolder()
        {
            _folderFilms = new List<Film>();
            _genres = new List<string>();

            if (Directory.Exists(SelectedSource.Path))
            {

                DirectoryInfo dir = new DirectoryInfo(SelectedSource.Path);
                var result = dir.GetFiles().Where(x => x.Name != FILENAME).Select(x => x.Name).ToList();

                result.RemoveAll(x => !_extensions.Contains(Path.GetExtension(x)));

                foreach (string fileName in result)
                {
                    var film = _catalogFilms.SingleOrDefault(x => x.FileName == fileName) ?? new Film { FileName = fileName, Title = GetTitleFromFileName(fileName) };
                    _folderFilms.Add(film);
                }

                foreach (var unknownFilm in _folderFilms.Where(x => !_catalogFilms.Any(y => y.FileName == x.FileName)))
                {
                    _catalogFilms.Add(unknownFilm);
                }

                _genres = _folderFilms.Where(x => !string.IsNullOrEmpty(x.Genre)).SelectMany(x => x.Genre.Split(',')).Select(x => x.Trim()).Distinct().ToList();
            }
        }

        private bool MatchesFilter(Film film)
        {
            string filter = CurrentFilter.ToLower();

            if (string.IsNullOrWhiteSpace(filter)) return true;

            if (film.Title.ToLower().Contains(filter)) return true;

            if ((film.Genre ?? string.Empty).ToLower().Contains(filter)) return true;

            if ((film.Casting ?? string.Empty).ToLower().Contains(filter)) return true;

            if ((film.Director ?? string.Empty).ToLower().Contains(filter)) return true;

            return false;
        }

        #endregion

    }
}
