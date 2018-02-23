using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;
using System.IO;

namespace MesFilms
{
    public partial class DisplayFilmUC : UserControl
    {
        public DisplayFilmUC()
        {
            InitializeComponent();
        }

        public DisplayFilmUC(Film film):this()
        {
            _title.Text = film.Title;
            _year.Text = film.Year.ToString();
            _description.Text = film.Description;
            _picture.ImageLocation = film.Image == null ? string.Empty : Path.Combine("cover", Path.GetFileName(film.Image));
            _genres.Text = film.Genre;
            _duration.Text = film.DurationInMinutes == 0 ? "" : string.Format("{0}h{1}", Math.Truncate(film.Duration.TotalHours), film.Duration.Minutes.ToString().PadLeft(2,'0'));
            _picStopwatch.Visible = film.DurationInMinutes != 0;
            _note.Text = film.Note == 0 ? "" : string.Format("{0}/10", film.Note);
            ratingUC1.SetRating(film.Note);
            ratingUC1.Visible = film.Note != 0;
            _filename.Text = film.FileName;
            _casting.Text = film.Casting;
            _director.Text = film.Director;
        }


        public void DisposeImage()
        {
            try
            {
                if (_picture.Image != null)
                {
                    _picture.Image.Dispose();
                    _picture.Image = null;
                    _picture.Dispose();
                }
            }
            catch { }
        }
    }
}
