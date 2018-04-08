namespace MesFilms
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this._panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnOk = new System.Windows.Forms.PictureBox();
            this._btnCancel = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._lblPicture = new System.Windows.Forms.Label();
            this._lblDescription = new System.Windows.Forms.Label();
            this._numRating = new System.Windows.Forms.NumericUpDown();
            this._lblRating = new System.Windows.Forms.Label();
            this._txtGenres = new System.Windows.Forms.TextBox();
            this._lblGenres = new System.Windows.Forms.Label();
            this._numDuration = new System.Windows.Forms.NumericUpDown();
            this._lblDuration = new System.Windows.Forms.Label();
            this._lblTitle = new System.Windows.Forms.Label();
            this._txtTitle = new System.Windows.Forms.TextBox();
            this._lblYear = new System.Windows.Forms.Label();
            this._txtDirector = new System.Windows.Forms.TextBox();
            this._lblDirector = new System.Windows.Forms.Label();
            this._numYear = new System.Windows.Forms.NumericUpDown();
            this._lblCasting = new System.Windows.Forms.Label();
            this._txtCasting = new System.Windows.Forms.TextBox();
            this._txtDescription = new System.Windows.Forms.RichTextBox();
            this._btnCover = new System.Windows.Forms.Button();
            this._dialog = new System.Windows.Forms.OpenFileDialog();
            this._panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._btnCancel)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._panel.Controls.Add(this.tableLayoutPanel1);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(721, 653);
            this._panel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._btnOk, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._btnCancel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._btnOk.BackColor = System.Drawing.Color.DimGray;
            this._btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnOk.Image = ((System.Drawing.Image)(resources.GetObject("_btnOk.Image")));
            this._btnOk.Location = new System.Drawing.Point(240, 585);
            this._btnOk.Margin = new System.Windows.Forms.Padding(7, 6, 43, 6);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(75, 58);
            this._btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._btnOk.TabIndex = 8;
            this._btnOk.TabStop = false;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("_btnCancel.Image")));
            this._btnCancel.Location = new System.Drawing.Point(401, 585);
            this._btnCancel.Margin = new System.Windows.Forms.Padding(43, 6, 7, 6);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 58);
            this._btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._btnCancel.TabIndex = 7;
            this._btnCancel.TabStop = false;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this._lblPicture, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this._lblDescription, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this._numRating, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this._lblRating, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this._txtGenres, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this._lblGenres, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this._numDuration, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this._lblDuration, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this._lblTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._txtTitle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._lblYear, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._txtDirector, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this._lblDirector, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this._numYear, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this._lblCasting, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this._txtCasting, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this._txtDescription, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this._btnCover, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 567);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // _lblPicture
            // 
            this._lblPicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblPicture.AutoSize = true;
            this._lblPicture.Location = new System.Drawing.Point(129, 533);
            this._lblPicture.Margin = new System.Windows.Forms.Padding(7, 10, 7, 0);
            this._lblPicture.Name = "_lblPicture";
            this._lblPicture.Size = new System.Drawing.Size(74, 22);
            this._lblPicture.TabIndex = 17;
            this._lblPicture.Text = "Affiche";
            // 
            // _lblDescription
            // 
            this._lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lblDescription.AutoSize = true;
            this._lblDescription.Location = new System.Drawing.Point(118, 395);
            this._lblDescription.Margin = new System.Windows.Forms.Padding(7, 10, 7, 0);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(85, 22);
            this._lblDescription.TabIndex = 15;
            this._lblDescription.Text = "Résumé";
            // 
            // _numRating
            // 
            this._numRating.DecimalPlaces = 1;
            this._numRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._numRating.Location = new System.Drawing.Point(218, 286);
            this._numRating.Margin = new System.Windows.Forms.Padding(8, 11, 8, 3);
            this._numRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._numRating.Name = "_numRating";
            this._numRating.Size = new System.Drawing.Size(112, 29);
            this._numRating.TabIndex = 12;
            this._numRating.Value = new decimal(new int[] {
            55,
            0,
            0,
            65536});
            // 
            // _lblRating
            // 
            this._lblRating.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblRating.AutoSize = true;
            this._lblRating.Location = new System.Drawing.Point(151, 291);
            this._lblRating.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblRating.Name = "_lblRating";
            this._lblRating.Size = new System.Drawing.Size(52, 22);
            this._lblRating.TabIndex = 11;
            this._lblRating.Text = "Note";
            // 
            // _txtGenres
            // 
            this._txtGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtGenres.Location = new System.Drawing.Point(217, 233);
            this._txtGenres.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._txtGenres.Name = "_txtGenres";
            this._txtGenres.Size = new System.Drawing.Size(479, 29);
            this._txtGenres.TabIndex = 10;
            // 
            // _lblGenres
            // 
            this._lblGenres.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblGenres.AutoSize = true;
            this._lblGenres.Location = new System.Drawing.Point(125, 236);
            this._lblGenres.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblGenres.Name = "_lblGenres";
            this._lblGenres.Size = new System.Drawing.Size(78, 22);
            this._lblGenres.TabIndex = 9;
            this._lblGenres.Text = "Genres";
            // 
            // _numDuration
            // 
            this._numDuration.Location = new System.Drawing.Point(218, 176);
            this._numDuration.Margin = new System.Windows.Forms.Padding(8, 11, 8, 3);
            this._numDuration.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this._numDuration.Name = "_numDuration";
            this._numDuration.Size = new System.Drawing.Size(112, 29);
            this._numDuration.TabIndex = 8;
            this._numDuration.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // _lblDuration
            // 
            this._lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblDuration.AutoSize = true;
            this._lblDuration.Location = new System.Drawing.Point(81, 181);
            this._lblDuration.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblDuration.Name = "_lblDuration";
            this._lblDuration.Size = new System.Drawing.Size(122, 22);
            this._lblDuration.TabIndex = 7;
            this._lblDuration.Text = "Durée (min.)";
            // 
            // _lblTitle
            // 
            this._lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblTitle.AutoSize = true;
            this._lblTitle.Location = new System.Drawing.Point(150, 16);
            this._lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(53, 22);
            this._lblTitle.TabIndex = 0;
            this._lblTitle.Text = "Titre";
            // 
            // _txtTitle
            // 
            this._txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtTitle.Location = new System.Drawing.Point(217, 13);
            this._txtTitle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._txtTitle.Name = "_txtTitle";
            this._txtTitle.Size = new System.Drawing.Size(479, 29);
            this._txtTitle.TabIndex = 1;
            // 
            // _lblYear
            // 
            this._lblYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblYear.AutoSize = true;
            this._lblYear.Location = new System.Drawing.Point(134, 71);
            this._lblYear.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblYear.Name = "_lblYear";
            this._lblYear.Size = new System.Drawing.Size(69, 22);
            this._lblYear.TabIndex = 2;
            this._lblYear.Text = "Année";
            // 
            // _txtDirector
            // 
            this._txtDirector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDirector.Location = new System.Drawing.Point(217, 123);
            this._txtDirector.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._txtDirector.Name = "_txtDirector";
            this._txtDirector.Size = new System.Drawing.Size(479, 29);
            this._txtDirector.TabIndex = 4;
            // 
            // _lblDirector
            // 
            this._lblDirector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblDirector.AutoSize = true;
            this._lblDirector.Location = new System.Drawing.Point(89, 126);
            this._lblDirector.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblDirector.Name = "_lblDirector";
            this._lblDirector.Size = new System.Drawing.Size(114, 22);
            this._lblDirector.TabIndex = 5;
            this._lblDirector.Text = "Réalisateur";
            // 
            // _numYear
            // 
            this._numYear.Location = new System.Drawing.Point(218, 66);
            this._numYear.Margin = new System.Windows.Forms.Padding(8, 11, 8, 3);
            this._numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this._numYear.Name = "_numYear";
            this._numYear.Size = new System.Drawing.Size(112, 29);
            this._numYear.TabIndex = 6;
            this._numYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // _lblCasting
            // 
            this._lblCasting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._lblCasting.AutoSize = true;
            this._lblCasting.Location = new System.Drawing.Point(122, 346);
            this._lblCasting.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this._lblCasting.Name = "_lblCasting";
            this._lblCasting.Size = new System.Drawing.Size(81, 22);
            this._lblCasting.TabIndex = 13;
            this._lblCasting.Text = "Casting";
            // 
            // _txtCasting
            // 
            this._txtCasting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._txtCasting.Location = new System.Drawing.Point(217, 343);
            this._txtCasting.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._txtCasting.Name = "_txtCasting";
            this._txtCasting.Size = new System.Drawing.Size(479, 29);
            this._txtCasting.TabIndex = 14;
            // 
            // _txtDescription
            // 
            this._txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtDescription.Location = new System.Drawing.Point(217, 391);
            this._txtDescription.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(479, 115);
            this._txtDescription.TabIndex = 16;
            this._txtDescription.Text = "";
            // 
            // _btnCover
            // 
            this._btnCover.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnCover.Location = new System.Drawing.Point(217, 525);
            this._btnCover.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this._btnCover.Name = "_btnCover";
            this._btnCover.Size = new System.Drawing.Size(50, 29);
            this._btnCover.TabIndex = 18;
            this._btnCover.Text = "...";
            this._btnCover.UseVisualStyleBackColor = true;
            this._btnCover.Click += new System.EventHandler(this._btnCover_Click);
            // 
            // _dialog
            // 
            this._dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(721, 653);
            this.Controls.Add(this._panel);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this._panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._btnCancel)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox _btnCancel;
        private System.Windows.Forms.PictureBox _btnOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.TextBox _txtTitle;
        private System.Windows.Forms.Label _lblYear;
        private System.Windows.Forms.TextBox _txtDirector;
        private System.Windows.Forms.Label _lblDirector;
        private System.Windows.Forms.NumericUpDown _numYear;
        private System.Windows.Forms.NumericUpDown _numDuration;
        private System.Windows.Forms.Label _lblDuration;
        private System.Windows.Forms.NumericUpDown _numRating;
        private System.Windows.Forms.Label _lblRating;
        private System.Windows.Forms.TextBox _txtGenres;
        private System.Windows.Forms.Label _lblGenres;
        private System.Windows.Forms.Label _lblCasting;
        private System.Windows.Forms.TextBox _txtCasting;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.RichTextBox _txtDescription;
        private System.Windows.Forms.Label _lblPicture;
        private System.Windows.Forms.Button _btnCover;
        private System.Windows.Forms.OpenFileDialog _dialog;
    }
}