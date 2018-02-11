using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Business
{
    public class MetaDataManager
    {
        private const string COVER_FOLDER = "cover";

        private WebClient _client = new WebClient { Encoding = Encoding.UTF8 };


        public Film[] GetFilms(string title)
        {
            string url = string.Format(ConfigurationSettings.AppSettings["QUERY_PATH"], ConfigurationSettings.AppSettings["USER_KEY"], GetTitleForURL(title));

            var result = _client.DownloadString(url);

            //Result film;

            var list = new List<Film>();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
            {
                var data = (RootObject)serializer.ReadObject(ms);

                foreach (var item in data.results)
                {
                    var film = new Film()
                    {
                        Description = item.overview,
                        ID = item.id,
                        Image = item.poster_path,
                        Title = item.title,
                        Year = GetYearFromReleaseDate(item.release_date),
                    };
                    
                    list.Add(film);
                }

            }

            return list.ToArray();
        }

        private int GetYearFromReleaseDate(string date)
        {
            return string.IsNullOrEmpty(date) ? 0 : Convert.ToInt32(date.Split('-').First());
        }

        private string GetTitleForURL(string title)
        {
            return title.Replace(' ', '+');
        }

        public DetailFilm GetDetail(int id)
        {
            string result = _client.DownloadString(string.Format(ConfigurationSettings.AppSettings["DETAIL_PATH"], id, ConfigurationSettings.AppSettings["USER_KEY"]));

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DetailFilm));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
            {
                var data = (DetailFilm)serializer.ReadObject(ms);
                return data;

            }

        }

        public Credits GetCredits(int id)
        {
            string result = _client.DownloadString(string.Format(ConfigurationSettings.AppSettings["CREDITS_PATH"], id, ConfigurationSettings.AppSettings["USER_KEY"]));

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Credits));
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)))
            {
                var data = (Credits)serializer.ReadObject(ms);
                return data;

            }
        }

        public void DownloadCover(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                string imageFileName = Path.GetFileName(filename);
                var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), COVER_FOLDER));
                if (!dir.Exists)
                {
                    dir.Create();
                }

                _client.DownloadFile(string.Format(ConfigurationSettings.AppSettings["IMAGE_PATH"], filename), Path.Combine(dir.FullName, imageFileName));
            }
        }

    }
}
