namespace GUI
{
    partial class frmFilm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFilmmanhinh = new System.Windows.Forms.ComboBox();
            this.cboFilmten = new System.Windows.Forms.ComboBox();
            this.dtpThoiGianphim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.cboFilmmanhinh);
            this.panel1.Controls.Add(this.cboFilmten);
            this.panel1.Controls.Add(this.dtpThoiGianphim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 108);
            this.panel1.TabIndex = 0;
            // 
            // cboFilmmanhinh
            // 
            this.cboFilmmanhinh.FormattingEnabled = true;
            this.cboFilmmanhinh.Location = new System.Drawing.Point(670, 58);
            this.cboFilmmanhinh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboFilmmanhinh.Name = "cboFilmmanhinh";
            this.cboFilmmanhinh.Size = new System.Drawing.Size(173, 24);
            this.cboFilmmanhinh.TabIndex = 6;
            // 
            // cboFilmten
            // 
            this.cboFilmten.FormattingEnabled = true;
            this.cboFilmten.Location = new System.Drawing.Point(425, 58);
            this.cboFilmten.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboFilmten.Name = "cboFilmten";
            this.cboFilmten.Size = new System.Drawing.Size(191, 24);
            this.cboFilmten.TabIndex = 5;
            // 
            // dtpThoiGianphim
            // 
            this.dtpThoiGianphim.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiGianphim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGianphim.Location = new System.Drawing.Point(179, 58);
            this.dtpThoiGianphim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpThoiGianphim.Name = "dtpThoiGianphim";
            this.dtpThoiGianphim.Size = new System.Drawing.Size(186, 22);
            this.dtpThoiGianphim.TabIndex = 4;
            this.dtpThoiGianphim.Value = new System.DateTime(2018, 4, 15, 10, 8, 45, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày chiếu:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phim:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(958, 547);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frmFilm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(958, 655);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFilm";
            this.Text = "frmFilm";
            this.Load += new System.EventHandler(this.frmFilm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGianphim;
        private System.Windows.Forms.ComboBox cboFilmmanhinh;
        private System.Windows.Forms.ComboBox cboFilmten;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}