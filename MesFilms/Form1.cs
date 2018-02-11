using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace MesFilms
{
    public partial class Form1 : Form
    {
        private PersistenceManager _persistence = PersistenceManager.Instance;

        private MetaDataManager _metadata = new MetaDataManager();

        private int _index = 0;

        Film[] _films;

        public Form1()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            _persistence.ScanFolder();
            _films = _persistence.FolderFilms.Where(x => x.ID != 0).OrderBy(x => x.FileName).ToArray();
            LoadUserControl();

            if (_persistence.FolderFilms.Any(x => x.ID == 0))
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void LoadUserControl()
        {
            foreach (DisplayFilmUC control in panel1.Controls.OfType<DisplayFilmUC>())
            {
                control.DisposeImage();
            }
            panel1.Controls.Clear();
            _indexLabel.Text = string.Empty;
            _source.Text = _persistence.SelectedSource.Name;
            if (_films.Any())
            {
                var uc = new DisplayFilmUC(_films[_index]);
                uc.Dock = DockStyle.Fill;
                panel1.Controls.Add(uc);
                _indexLabel.Text = string.Format("{0} / {1}", _index + 1, _films.Length);
                
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (_index > 0)
            {
                _index--;
                LoadUserControl();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_index < _films.Length - 1)
            {
                _index++;
                LoadUserControl();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SourceSelection selection = new SourceSelection();
            selection.ShowDialog();
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("SOURCE"); 
            config.AppSettings.Settings.Add("SOURCE", _persistence.SelectedSource.Name);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
            _index = 0;
            Refresh();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nouveautes news = new Nouveautes();
            news.ShowDialog();
            _persistence.ScanFolder();
            Refresh();
        }

        private void _playButton_Click(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(_persistence.SelectedSource.Path, _films[_index].FileName);
            var process = new Process();
            process.StartInfo.FileName = fullPath;
            process.Start();
            

        }

        private void _filter_Click(object sender, EventArgs e)
        {
            _persistence.CurrentFilter = richTextBox1.Text;
            _index = 0;
            Refresh();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _persistence.CurrentFilter = richTextBox1.Text;
                _index = 0;
                Refresh();
            }
        }

        private void _clearFilter_Click(object sender, EventArgs e)
        {
            _persistence.CurrentFilter = string.Empty;
            richTextBox1.Text = string.Empty;
            _index = 0;
            Refresh();
        }
    }
}
