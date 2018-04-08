using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MesFilms
{
    public partial class Edit : Form
    {
        protected Film _film;

        public Film Film => _film;

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Film film):this()
        {
            _film = film;
            FillFilmInfo();
        }

        private void FillFilmInfo()
        {
            _txtTitle.Text = _film.Title;
            _numYear.Value = _film.Year;
            _txtDirector.Text = _film.Director;
            _numRating.Value = Convert.ToDecimal(_film.Note);
            _txtCasting.Text = _film.Casting;
            _txtGenres.Text = _film.Genre;
            _txtDescription.Text = _film.Description;
            _numDuration.Value = _film.DurationInMinutes;

        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            _film.Title = _txtTitle.Text;
            _film.Year = Convert.ToInt32(_numYear.Value);
            _film.Director = _txtDirector.Text;
            _film.Note = Convert.ToDouble(_numRating.Value);
            _film.Casting = _txtCasting.Text;
            _film.DurationInMinutes = Convert.ToInt32(_numDuration.Value);
            _film.Genre = _txtGenres.Text;
            _film.Description = _txtDescription.Text;

            this.DialogResult = DialogResult.OK;
        }
        
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void _btnCover_Click(object sender, EventArgs e)
        {
            var result = _dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var shortName = Path.GetFileName(_dialog.FileName);
                var destFileName = Path.Combine("cover", shortName);
                if (!File.Exists(destFileName))
                {
                    File.Copy(_dialog.FileName, destFileName);
                }
                _film.Image = "/" + shortName;
            }
        }
    }
}
