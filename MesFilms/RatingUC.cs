using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MesFilms
{
    [ToolboxItem(true)]
    public partial class RatingUC : UserControl
    {
        public RatingUC()
        {
            InitializeComponent();
        }
       
        public void SetRating(double rating)
        {
            double roundRating = Math.Round(rating, 0);
            pictureBox1.Image = (roundRating >= 2) ? Properties.Resources.star_full : ((roundRating >= 1) ? Properties.Resources.star_half : Properties.Resources.star_empty);
            pictureBox2.Image = (roundRating >= 4) ? Properties.Resources.star_full : ((roundRating >= 3) ? Properties.Resources.star_half : Properties.Resources.star_empty);
            pictureBox3.Image = (roundRating >= 6) ? Properties.Resources.star_full : ((roundRating >= 5) ? Properties.Resources.star_half : Properties.Resources.star_empty);
            pictureBox4.Image = (roundRating >= 8) ? Properties.Resources.star_full : ((roundRating >= 7) ? Properties.Resources.star_half : Properties.Resources.star_empty);
            pictureBox5.Image = (roundRating >= 10) ? Properties.Resources.star_full : ((roundRating >= 9) ? Properties.Resources.star_half : Properties.Resources.star_empty);
        }
    }
}
