namespace MesFilms
{
    partial class Form1
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
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._filter = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._clearFilter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._selectFolderButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._playButton = new System.Windows.Forms.Button();
            this._indexLabel = new System.Windows.Forms.Label();
            this._source = new System.Windows.Forms.Label();
            this._edit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._edit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 519);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.tableLayoutPanel1.SetRowSpan(this.button1, 2);
            this.button1.Size = new System.Drawing.Size(94, 513);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.button2.Location = new System.Drawing.Point(899, 3);
            this.button2.Name = "button2";
            this.tableLayoutPanel1.SetRowSpan(this.button2, 2);
            this.button2.Size = new System.Drawing.Size(94, 513);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 443);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Controls.Add(this._filter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._clearFilter, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(103, 452);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(790, 64);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // _filter
            // 
            this._filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_filter.BackgroundImage")));
            this._filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._filter.Location = new System.Drawing.Point(656, 3);
            this._filter.Name = "_filter";
            this._filter.Size = new System.Drawing.Size(58, 58);
            this._filter.TabIndex = 7;
            this._filter.UseVisualStyleBackColor = true;
            this._filter.Click += new System.EventHandler(this._filter_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(3, 7);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(644, 50);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // _clearFilter
            // 
            this._clearFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._clearFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_clearFilter.BackgroundImage")));
            this._clearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._clearFilter.Location = new System.Drawing.Point(726, 3);
            this._clearFilter.Name = "_clearFilter";
            this._clearFilter.Size = new System.Drawing.Size(58, 58);
            this._clearFilter.TabIndex = 9;
            this._clearFilter.UseVisualStyleBackColor = true;
            this._clearFilter.Click += new System.EventHandler(this._clearFilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(970, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _selectFolderButton
            // 
            this._selectFolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_selectFolderButton.BackgroundImage")));
            this._selectFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._selectFolderButton.Location = new System.Drawing.Point(46, 12);
            this._selectFolderButton.Name = "_selectFolderButton";
            this._selectFolderButton.Size = new System.Drawing.Size(70, 70);
            this._selectFolderButton.TabIndex = 2;
            this._selectFolderButton.UseVisualStyleBackColor = true;
            this._selectFolderButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(222, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _playButton
            // 
            this._playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_playButton.BackgroundImage")));
            this._playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._playButton.Location = new System.Drawing.Point(134, 12);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(70, 70);
            this._playButton.TabIndex = 4;
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this._playButton_Click);
            // 
            // _indexLabel
            // 
            this._indexLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._indexLabel.AutoSize = true;
            this._indexLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._indexLabel.ForeColor = System.Drawing.Color.White;
            this._indexLabel.Location = new System.Drawing.Point(502, 12);
            this._indexLabel.Name = "_indexLabel";
            this._indexLabel.Size = new System.Drawing.Size(87, 32);
            this._indexLabel.TabIndex = 5;
            this._indexLabel.Text = "1 / 65";
            // 
            // _source
            // 
            this._source.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._source.AutoSize = true;
            this._source.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._source.ForeColor = System.Drawing.Color.White;
            this._source.Location = new System.Drawing.Point(468, 48);
            this._source.Name = "_source";
            this._source.Size = new System.Drawing.Size(165, 40);
            this._source.TabIndex = 6;
            this._source.Text = "Films HD";
            // 
            // _edit
            // 
            this._edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this._edit.Image = ((System.Drawing.Image)(resources.GetObject("_edit.Image")));
            this._edit.Location = new System.Drawing.Point(883, 12);
            this._edit.Name = "_edit";
            this._edit.Size = new System.Drawing.Size(70, 70);
            this._edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._edit.TabIndex = 7;
            this._edit.TabStop = false;
            this._edit.Click += new System.EventHandler(this._edit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1076, 631);
            this.ControlBox = false;
            this.Controls.Add(this._edit);
            this.Controls.Add(this._source);
            this.Controls.Add(this._indexLabel);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this._selectFolderButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mes Films";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button _selectFolderButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.Label _indexLabel;
        private System.Windows.Forms.Label _source;
        private System.Windows.Forms.Button _filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button _clearFilter;
        private System.Windows.Forms.PictureBox _edit;
    }
}

