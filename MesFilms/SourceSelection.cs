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
    public partial class SourceSelection : Form
    {
        #region Members

        private PersistenceManager _manager;

        #endregion

        #region Constructor

        public SourceSelection()
        {
            InitializeComponent();
            _sourcesList.DisplayMember = "Name";
            _manager = PersistenceManager.Instance;
        }

        #endregion


        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceSelection_Load(object sender, EventArgs e)
        {
            _sourcesList.Items.Clear();
            
            foreach (var source in _manager.Sources)
            {
                if (source.Exists)
                {
                    _sourcesList.Items.Add(source);
                }
            }

            _sourcesList.SelectedItem = _manager.SelectedSource;
        }

        #endregion

        private void _cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _OK_Click(object sender, EventArgs e)
        {
            _manager.SelectedSource = (Source)_sourcesList.SelectedItem;
            Close();
        }
    }
}
