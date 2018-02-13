using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;
using System.Configuration;

namespace MesFilms
{
    public partial class MetaDataPreview : UserControl
    {
        private Film _film;

        public event EventHandler OkClick;

        public MetaDataPreview()
        {
            InitializeComponent();
        }

        public MetaDataPreview(Film data, string fileName):this()
        {

            _film = data;
            _film.FileName = fileName;
            _title.Text = data.Title;
            _year.Text = data.Year.ToString();
            _picture.ImageLocation = string.Format(ConfigurationSettings.AppSettings["IMAGE_PATH"], data.Image);
            _description.Text = data.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var manager = new MetaDataManager();
            manager.DownloadCover(_film.Image);

            var film = PersistenceManager.Instance.Films.FirstOrDefault(x => x.FileName == _film.FileName);
            if (film != null)
            {
                film.Description = _film.Description;
                film.ID = _film.ID;
                film.Title = _film.Title;
                film.Year = _film.Year;
                film.Image = _film.Image;
                PersistenceManager.Instance.Save();

                MetaDataManager mdManager = new MetaDataManager();

                var detail = mdManager.GetDetail(film.ID);
                film.DurationInMinutes = detail.runtime ?? 0;
                film.Genre = string.Join(", ", detail.genres.Select(x => x.name));
                film.Note = Math.Round(detail.vote_average,1);

                var credits = mdManager.GetCredits(film.ID);
                film.Director = credits.crew.Any(x => x.job == "Director") ? credits.crew.FirstOrDefault(x => x.job == "Director").name : string.Empty;
                film.Casting = string.Join(", ", credits.cast.Select(x => x.name));

                if (OkClick != null)
                {
                    OkClick(this, EventArgs.Empty);
                }
            }
        }
    }
}
