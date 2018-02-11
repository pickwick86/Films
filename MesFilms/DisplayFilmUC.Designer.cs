namespace MesFilms
{
    partial class DisplayFilmUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            DisposeImage();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._director = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._filename = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this._genres = new System.Windows.Forms.Label();
            this._description = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._duration = new System.Windows.Forms.Label();
            this._note = new System.Windows.Forms.Label();
            this._year = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._picture = new System.Windows.Forms.PictureBox();
            this._title = new System.Windows.Forms.Label();
            this._casting = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this._director, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this._filename, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._genres, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._description, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._picture, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._casting, 1, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _director
            // 
            this._director.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._director.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._director, 2);
            this._director.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._director.ForeColor = System.Drawing.Color.White;
            this._director.Location = new System.Drawing.Point(430, 40);
            this._director.Name = "_director";
            this._director.Size = new System.Drawing.Size(133, 27);
            this._director.TabIndex = 16;
            this._director.Text = "Réalisateur";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(400, 149);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(591, 2);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(400, 507);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(591, 2);
            this.panel4.TabIndex = 12;
            // 
            // _filename
            // 
            this._filename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._filename.AutoSize = true;
            this._filename.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._filename.ForeColor = System.Drawing.Color.White;
            this._filename.Location = new System.Drawing.Point(400, 513);
            this._filename.Name = "_filename";
            this._filename.Size = new System.Drawing.Size(161, 27);
            this._filename.TabIndex = 11;
            this._filename.Text = "Filename.mkv";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(400, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 2);
            this.panel3.TabIndex = 10;
            // 
            // _genres
            // 
            this._genres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._genres.AutoSize = true;
            this._genres.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._genres.ForeColor = System.Drawing.Color.White;
            this._genres.Location = new System.Drawing.Point(650, 117);
            this._genres.Name = "_genres";
            this._genres.Size = new System.Drawing.Size(91, 27);
            this._genres.TabIndex = 4;
            this._genres.Text = "Genres";
            // 
            // _description
            // 
            this._description.BackColor = System.Drawing.Color.DimGray;
            this._description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._description.Cursor = System.Windows.Forms.Cursors.Default;
            this._description.Dock = System.Windows.Forms.DockStyle.Fill;
            this._description.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._description.ForeColor = System.Drawing.Color.White;
            this._description.Location = new System.Drawing.Point(400, 205);
            this._description.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            this._description.Size = new System.Drawing.Size(591, 296);
            this._description.TabIndex = 6;
            this._description.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(400, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 2);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this._duration, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this._note, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._year, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(397, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(597, 30);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // _duration
            // 
            this._duration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._duration.AutoSize = true;
            this._duration.Font = new System.Drawing.Font("Arial", 18F);
            this._duration.ForeColor = System.Drawing.Color.White;
            this._duration.Location = new System.Drawing.Point(529, 1);
            this._duration.Name = "_duration";
            this._duration.Size = new System.Drawing.Size(65, 27);
            this._duration.TabIndex = 4;
            this._duration.Text = "1h30";
            // 
            // _note
            // 
            this._note.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._note.AutoSize = true;
            this._note.Font = new System.Drawing.Font("Arial", 18F);
            this._note.ForeColor = System.Drawing.Color.White;
            this._note.Location = new System.Drawing.Point(3, 1);
            this._note.Name = "_note";
            this._note.Size = new System.Drawing.Size(78, 27);
            this._note.TabIndex = 3;
            this._note.Text = "6,5/10";
            this._note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _year
            // 
            this._year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._year.AutoSize = true;
            this._year.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._year.ForeColor = System.Drawing.Color.White;
            this._year.Location = new System.Drawing.Point(266, 1);
            this._year.Name = "_year";
            this._year.Size = new System.Drawing.Size(64, 27);
            this._year.TabIndex = 2;
            this._year.Text = "2014";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 2);
            this.panel2.TabIndex = 9;
            // 
            // _picture
            // 
            this._picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picture.Location = new System.Drawing.Point(3, 81);
            this._picture.Name = "_picture";
            this.tableLayoutPanel1.SetRowSpan(this._picture, 9);
            this._picture.Size = new System.Drawing.Size(391, 458);
            this._picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picture.TabIndex = 0;
            this._picture.TabStop = false;
            // 
            // _title
            // 
            this._title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this._title, 2);
            this._title.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.ForeColor = System.Drawing.Color.White;
            this._title.Location = new System.Drawing.Point(458, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(77, 34);
            this._title.TabIndex = 13;
            this._title.Text = "Titre";
            // 
            // _casting
            // 
            this._casting.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._casting.AutoSize = true;
            this._casting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._casting.ForeColor = System.Drawing.Color.White;
            this._casting.Location = new System.Drawing.Point(400, 157);
            this._casting.Name = "_casting";
            this._casting.Size = new System.Drawing.Size(81, 24);
            this._casting.TabIndex = 15;
            this._casting.Text = "Casting";
            this._casting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayFilmUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DisplayFilmUC";
            this.Size = new System.Drawing.Size(994, 542);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox _picture;
        private System.Windows.Forms.Label _year;
        private System.Windows.Forms.Label _genres;
        private System.Windows.Forms.RichTextBox _description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label _duration;
        private System.Windows.Forms.Label _note;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _filename;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label _casting;
        private System.Windows.Forms.Label _director;
    }
}
