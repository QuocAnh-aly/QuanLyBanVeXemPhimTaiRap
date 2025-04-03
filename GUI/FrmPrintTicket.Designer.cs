namespace GUI
{
    partial class FrmPrintTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelinforfilm = new System.Windows.Forms.Label();
            this.labelinfortime = new System.Windows.Forms.Label();
            this.labelinforcustomer = new System.Windows.Forms.Label();
            this.labelinforidkh = new System.Windows.Forms.Label();
            this.labelinforghe = new System.Windows.Forms.Label();
            this.labelinforphong = new System.Windows.Forms.Label();
            this.labelinfortien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Vé";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelinforfilm
            // 
            this.labelinforfilm.AutoSize = true;
            this.labelinforfilm.Location = new System.Drawing.Point(43, 107);
            this.labelinforfilm.Name = "labelinforfilm";
            this.labelinforfilm.Size = new System.Drawing.Size(44, 16);
            this.labelinforfilm.TabIndex = 1;
            this.labelinforfilm.Text = "label2";
            // 
            // labelinfortime
            // 
            this.labelinfortime.AutoSize = true;
            this.labelinfortime.Location = new System.Drawing.Point(43, 140);
            this.labelinfortime.Name = "labelinfortime";
            this.labelinfortime.Size = new System.Drawing.Size(44, 16);
            this.labelinfortime.TabIndex = 2;
            this.labelinfortime.Text = "label3";
            // 
            // labelinforcustomer
            // 
            this.labelinforcustomer.AutoSize = true;
            this.labelinforcustomer.Location = new System.Drawing.Point(43, 173);
            this.labelinforcustomer.Name = "labelinforcustomer";
            this.labelinforcustomer.Size = new System.Drawing.Size(44, 16);
            this.labelinforcustomer.TabIndex = 3;
            this.labelinforcustomer.Text = "label4";
            // 
            // labelinforidkh
            // 
            this.labelinforidkh.AutoSize = true;
            this.labelinforidkh.Location = new System.Drawing.Point(43, 208);
            this.labelinforidkh.Name = "labelinforidkh";
            this.labelinforidkh.Size = new System.Drawing.Size(44, 16);
            this.labelinforidkh.TabIndex = 4;
            this.labelinforidkh.Text = "label5";
            // 
            // labelinforghe
            // 
            this.labelinforghe.AutoSize = true;
            this.labelinforghe.Location = new System.Drawing.Point(43, 243);
            this.labelinforghe.Name = "labelinforghe";
            this.labelinforghe.Size = new System.Drawing.Size(44, 16);
            this.labelinforghe.TabIndex = 5;
            this.labelinforghe.Text = "label6";
            this.labelinforghe.Click += new System.EventHandler(this.labelinforghe_Click);
            // 
            // labelinforphong
            // 
            this.labelinforphong.AutoSize = true;
            this.labelinforphong.Location = new System.Drawing.Point(43, 275);
            this.labelinforphong.Name = "labelinforphong";
            this.labelinforphong.Size = new System.Drawing.Size(44, 16);
            this.labelinforphong.TabIndex = 6;
            this.labelinforphong.Text = "label7";
            this.labelinforphong.Click += new System.EventHandler(this.labelinforphong_Click);
            // 
            // labelinfortien
            // 
            this.labelinfortien.AutoSize = true;
            this.labelinfortien.Location = new System.Drawing.Point(43, 305);
            this.labelinfortien.Name = "labelinfortien";
            this.labelinfortien.Size = new System.Drawing.Size(44, 16);
            this.labelinfortien.TabIndex = 7;
            this.labelinfortien.Text = "label8";
            // 
            // FrmPrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelinfortien);
            this.Controls.Add(this.labelinforphong);
            this.Controls.Add(this.labelinforghe);
            this.Controls.Add(this.labelinforidkh);
            this.Controls.Add(this.labelinforcustomer);
            this.Controls.Add(this.labelinfortime);
            this.Controls.Add(this.labelinforfilm);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrintTicket";
            this.Text = "FrmPrintTicket";
            this.Load += new System.EventHandler(this.FrmPrintTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelinforfilm;
        private System.Windows.Forms.Label labelinfortime;
        private System.Windows.Forms.Label labelinforcustomer;
        private System.Windows.Forms.Label labelinforidkh;
        private System.Windows.Forms.Label labelinforghe;
        private System.Windows.Forms.Label labelinforphong;
        private System.Windows.Forms.Label labelinfortien;
    }
}