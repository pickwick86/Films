using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;

namespace MesFilms
{
    public partial class Nouveautes : Form
    {

        private PersistenceManager _persistence = PersistenceManager.Instance;

        private MetaDataManager _metadata = new MetaDataManager();

        public Nouveautes()
        {
            InitializeComponent();
        }

        private void Nouveautes_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void RefreshContent()
        {
            var films = _persistence.FolderFilms;
            flowLayoutPanel1.Controls.Clear();
            _title.Text = string.Empty;
            comboBox1.Items.Clear();
            
            var unknowns = films.Where(x => x.ID == 0);
            
            foreach (var unknown in unknowns)
            {
                comboBox1.Items.Add(unknown);
            }

            
            _persistence.Save();

            if (!unknowns.Any())
            {
                this.Close();
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }


        private void RefreshMetadata(string title, string fileName)
        {
            var datas = _metadata.GetFilms(title);

            flowLayoutPanel1.Controls.Clear();
            foreach (var data in datas)
            {
                MetaDataPreview preview = new MetaDataPreview(data, fileName);
                preview.OkClick += new EventHandler(preview_OkClick);
                flowLayoutPanel1.Controls.Add(preview);
            }
        }

        void preview_OkClick(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = ((Film)comboBox1.SelectedItem).FileName;
            RefreshMetadata(_title.Text, fileName);
        }

        private void _title_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string fileName = ((Film)comboBox1.SelectedItem).FileName;
                RefreshMetadata(_title.Text, fileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string fileName = ((Film)comboBox1.SelectedItem).FileName;
                string title = _persistence.GetTitleFromFileName(fileName);
                _title.Text = title;

                RefreshMetadata(title, fileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnEdit_Click(object sender, EventArgs e)
        {
            var film = (Film)comboBox1.SelectedItem;
            using (var editForm = new Edit(film))
            {
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    film = editForm.Film;
                    film.ID = -1;
                    _persistence.Save();
                    RefreshContent();
                }
            }
        }
    }
}
