namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class FilmUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttondatve = new System.Windows.Forms.Button();
            this.labeltenfilm = new System.Windows.Forms.Label();
            this.picturefilm = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturefilm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.buttondatve);
            this.panel1.Controls.Add(this.labeltenfilm);
            this.panel1.Controls.Add(this.picturefilm);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 242);
            this.panel1.TabIndex = 0;
            // 
            // buttondatve
            // 
            this.buttondatve.Location = new System.Drawing.Point(5, 189);
            this.buttondatve.Name = "buttondatve";
            this.buttondatve.Size = new System.Drawing.Size(184, 50);
            this.buttondatve.TabIndex = 2;
            this.buttondatve.Text = "Đặt vé";
            this.buttondatve.UseVisualStyleBackColor = true;
            this.buttondatve.Click += new System.EventHandler(this.buttondatve_Click_1);
            // 
            // labeltenfilm
            // 
            this.labeltenfilm.AutoSize = true;
            this.labeltenfilm.Location = new System.Drawing.Point(67, 161);
            this.labeltenfilm.Name = "labeltenfilm";
            this.labeltenfilm.Size = new System.Drawing.Size(55, 16);
            this.labeltenfilm.TabIndex = 1;
            this.labeltenfilm.Text = "Địa Đạo";
            // 
            // picturefilm
            // 
            this.picturefilm.Image = ((System.Drawing.Image)(resources.GetObject("picturefilm.Image")));
            this.picturefilm.Location = new System.Drawing.Point(41, 3);
            this.picturefilm.Name = "picturefilm";
            this.picturefilm.Size = new System.Drawing.Size(108, 140);
            this.picturefilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturefilm.TabIndex = 0;
            this.picturefilm.TabStop = false;
            // 
            // FilmUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FilmUC";
            this.Size = new System.Drawing.Size(195, 243);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturefilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picturefilm;
        private System.Windows.Forms.Button buttondatve;
        private System.Windows.Forms.Label labeltenfilm;
    }
}
