namespace MesFilms
{
    partial class MetaDataPreview
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._picture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this._title = new System.Windows.Forms.Label();
            this._year = new System.Windows.Forms.Label();
            this._description = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this._picture, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this._title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._year, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._description, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _picture
            // 
            this._picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picture.Location = new System.Drawing.Point(6, 5);
            this._picture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._picture.Name = "_picture";
            this.tableLayoutPanel1.SetRowSpan(this._picture, 3);
            this._picture.Size = new System.Drawing.Size(148, 161);
            this._picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picture.TabIndex = 0;
            this._picture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(876, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.tableLayoutPanel1.SetRowSpan(this.button1, 3);
            this.button1.Size = new System.Drawing.Size(68, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _title
            // 
            this._title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._title.AutoSize = true;
            this._title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.ForeColor = System.Drawing.Color.White;
            this._title.Location = new System.Drawing.Point(166, 9);
            this._title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(698, 22);
            this._title.TabIndex = 2;
            this._title.Text = "Man Of Steel";
            // 
            // _year
            // 
            this._year.AutoSize = true;
            this._year.Font = new System.Drawing.Font("Arial", 14.25F);
            this._year.ForeColor = System.Drawing.Color.White;
            this._year.Location = new System.Drawing.Point(163, 40);
            this._year.Name = "_year";
            this._year.Size = new System.Drawing.Size(54, 22);
            this._year.TabIndex = 3;
            this._year.Text = "2013";
            // 
            // _description
            // 
            this._description.BackColor = System.Drawing.Color.DimGray;
            this._description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._description.Dock = System.Windows.Forms.DockStyle.Fill;
            this._description.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this._description.ForeColor = System.Drawing.Color.White;
            this._description.Location = new System.Drawing.Point(163, 73);
            this._description.Name = "_description";
            this._description.ReadOnly = true;
            this._description.Size = new System.Drawing.Size(704, 95);
            this._description.TabIndex = 4;
            this._description.Text = "";
            // 
            // MetaDataPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MetaDataPreview";
            this.Size = new System.Drawing.Size(950, 171);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox _picture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _title;
        private System.Windows.Forms.Label _year;
        private System.Windows.Forms.RichTextBox _description;
    }
}
