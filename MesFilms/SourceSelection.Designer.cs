namespace MesFilms
{
    partial class SourceSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SourceSelection));
            this._sourcesList = new System.Windows.Forms.ComboBox();
            this._cancel = new System.Windows.Forms.PictureBox();
            this._OK = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OK)).BeginInit();
            this.SuspendLayout();
            // 
            // _sourcesList
            // 
            this._sourcesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sourcesList.BackColor = System.Drawing.Color.LightGray;
            this._sourcesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sourcesList.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sourcesList.ForeColor = System.Drawing.Color.White;
            this._sourcesList.FormattingEnabled = true;
            this._sourcesList.Location = new System.Drawing.Point(114, 116);
            this._sourcesList.Name = "_sourcesList";
            this._sourcesList.Size = new System.Drawing.Size(278, 42);
            this._sourcesList.TabIndex = 0;
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.BackColor = System.Drawing.Color.DimGray;
            this._cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._cancel.Image = ((System.Drawing.Image)(resources.GetObject("_cancel.Image")));
            this._cancel.Location = new System.Drawing.Point(322, 201);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(70, 70);
            this._cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._cancel.TabIndex = 2;
            this._cancel.TabStop = false;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _OK
            // 
            this._OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._OK.BackColor = System.Drawing.Color.DimGray;
            this._OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this._OK.Image = ((System.Drawing.Image)(resources.GetObject("_OK.Image")));
            this._OK.Location = new System.Drawing.Point(114, 201);
            this._OK.Name = "_OK";
            this._OK.Size = new System.Drawing.Size(70, 70);
            this._OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._OK.TabIndex = 3;
            this._OK.TabStop = false;
            this._OK.Click += new System.EventHandler(this._OK_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(507, 297);
            this.panel1.TabIndex = 5;
            // 
            // SourceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 297);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this._OK);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._sourcesList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SourceSelection";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SourceSelection";
            this.Load += new System.EventHandler(this.SourceSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _sourcesList;
        private System.Windows.Forms.PictureBox _cancel;
        private System.Windows.Forms.PictureBox _OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}