namespace GUI
{
    partial class frmCustomer
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
            this.btnCofirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnThanhVien = new System.Windows.Forms.Panel();
            this.buttonchonphim = new System.Windows.Forms.Button();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.btnShowCustomer = new System.Windows.Forms.Button();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.nudPoint = new System.Windows.Forms.NumericUpDown();
            this.lblCusID = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.lblCusINumber = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.lblCusBirth = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.lblCusPhone = new System.Windows.Forms.Label();
            this.lblCusPoint = new System.Windows.Forms.Label();
            this.txtCusBirth = new System.Windows.Forms.TextBox();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.txtCusINumber = new System.Windows.Forms.TextBox();
            this.lblCusName = new System.Windows.Forms.Label();
            this.pnThanhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCofirm
            // 
            this.btnCofirm.AutoSize = true;
            this.btnCofirm.Location = new System.Drawing.Point(16, 87);
            this.btnCofirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCofirm.Name = "btnCofirm";
            this.btnCofirm.Size = new System.Drawing.Size(120, 35);
            this.btnCofirm.TabIndex = 2;
            this.btnCofirm.Text = "Xác Nhận";
            this.btnCofirm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 13;
            // 
            // pnThanhVien
            // 
            this.pnThanhVien.Controls.Add(this.buttonchonphim);
            this.pnThanhVien.Controls.Add(this.btnSearchCus);
            this.pnThanhVien.Controls.Add(this.btnShowCustomer);
            this.pnThanhVien.Controls.Add(this.dtgvCustomer);
            this.pnThanhVien.Controls.Add(this.btnUpdateCustomer);
            this.pnThanhVien.Controls.Add(this.btnAddCustomer);
            this.pnThanhVien.Controls.Add(this.txtSearchCus);
            this.pnThanhVien.Controls.Add(this.btnDeleteCustomer);
            this.pnThanhVien.Controls.Add(this.grpCustomer);
            this.pnThanhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThanhVien.Location = new System.Drawing.Point(0, 0);
            this.pnThanhVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnThanhVien.Name = "pnThanhVien";
            this.pnThanhVien.Size = new System.Drawing.Size(875, 752);
            this.pnThanhVien.TabIndex = 1;
            // 
            // buttonchonphim
            // 
            this.buttonchonphim.BackColor = System.Drawing.Color.LightCoral;
            this.buttonchonphim.Location = new System.Drawing.Point(729, 129);
            this.buttonchonphim.Name = "buttonchonphim";
            this.buttonchonphim.Size = new System.Drawing.Size(131, 53);
            this.buttonchonphim.TabIndex = 30;
            this.buttonchonphim.Text = "Chọn Phim";
            this.buttonchonphim.UseVisualStyleBackColor = false;
            this.buttonchonphim.Click += new System.EventHandler(this.buttonchonphim_Click);
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.BackgroundImage = global::GUI.Properties.Resources.search_icon;
            this.btnSearchCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCus.Location = new System.Drawing.Point(774, 294);
            this.btnSearchCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(35, 31);
            this.btnSearchCus.TabIndex = 29;
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click_1);
            // 
            // btnShowCustomer
            // 
            this.btnShowCustomer.Location = new System.Drawing.Point(604, 46);
            this.btnShowCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCustomer.Name = "btnShowCustomer";
            this.btnShowCustomer.Size = new System.Drawing.Size(91, 53);
            this.btnShowCustomer.TabIndex = 23;
            this.btnShowCustomer.Text = "Xem";
            this.btnShowCustomer.UseVisualStyleBackColor = true;
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AllowUserToAddRows = false;
            this.dtgvCustomer.AllowUserToDeleteRows = false;
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(12, 329);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCustomer.MultiSelect = false;
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.ReadOnly = true;
            this.dtgvCustomer.RowHeadersWidth = 51;
            this.dtgvCustomer.RowTemplate.Height = 24;
            this.dtgvCustomer.Size = new System.Drawing.Size(797, 393);
            this.dtgvCustomer.TabIndex = 22;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(604, 160);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(91, 53);
            this.btnUpdateCustomer.TabIndex = 26;
            this.btnUpdateCustomer.Text = "Sửa";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click_1);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(604, 103);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(91, 53);
            this.btnAddCustomer.TabIndex = 27;
            this.btnAddCustomer.Text = "Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click_1);
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Location = new System.Drawing.Point(604, 299);
            this.txtSearchCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(164, 26);
            this.txtSearchCus.TabIndex = 28;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(604, 217);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(91, 53);
            this.btnDeleteCustomer.TabIndex = 25;
            this.btnDeleteCustomer.Text = "Xóa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click_1);
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.Silver;
            this.grpCustomer.Controls.Add(this.nudPoint);
            this.grpCustomer.Controls.Add(this.lblCusID);
            this.grpCustomer.Controls.Add(this.txtCusID);
            this.grpCustomer.Controls.Add(this.txtCusAddress);
            this.grpCustomer.Controls.Add(this.lblCusINumber);
            this.grpCustomer.Controls.Add(this.txtCusName);
            this.grpCustomer.Controls.Add(this.lblCusBirth);
            this.grpCustomer.Controls.Add(this.txtCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPhone);
            this.grpCustomer.Controls.Add(this.lblCusPoint);
            this.grpCustomer.Controls.Add(this.txtCusBirth);
            this.grpCustomer.Controls.Add(this.lblCusAddress);
            this.grpCustomer.Controls.Add(this.txtCusINumber);
            this.grpCustomer.Controls.Add(this.lblCusName);
            this.grpCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(12, 21);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCustomer.Size = new System.Drawing.Size(586, 285);
            this.grpCustomer.TabIndex = 24;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // nudPoint
            // 
            this.nudPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPoint.Location = new System.Drawing.Point(476, 37);
            this.nudPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPoint.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPoint.Name = "nudPoint";
            this.nudPoint.Size = new System.Drawing.Size(75, 26);
            this.nudPoint.TabIndex = 5;
            this.nudPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusID.Location = new System.Drawing.Point(33, 42);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(66, 19);
            this.lblCusID.TabIndex = 4;
            this.lblCusID.Text = "Mã KH:";
            // 
            // txtCusID
            // 
            this.txtCusID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.Location = new System.Drawing.Point(133, 37);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(191, 26);
            this.txtCusID.TabIndex = 2;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAddress.Location = new System.Drawing.Point(133, 147);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(191, 26);
            this.txtCusAddress.TabIndex = 2;
            // 
            // lblCusINumber
            // 
            this.lblCusINumber.AutoSize = true;
            this.lblCusINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusINumber.Location = new System.Drawing.Point(43, 222);
            this.lblCusINumber.Name = "lblCusINumber";
            this.lblCusINumber.Size = new System.Drawing.Size(65, 19);
            this.lblCusINumber.TabIndex = 4;
            this.lblCusINumber.Text = "CMND:";
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(133, 71);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(191, 26);
            this.txtCusName.TabIndex = 2;
            // 
            // lblCusBirth
            // 
            this.lblCusBirth.AutoSize = true;
            this.lblCusBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusBirth.Location = new System.Drawing.Point(24, 108);
            this.lblCusBirth.Name = "lblCusBirth";
            this.lblCusBirth.Size = new System.Drawing.Size(81, 19);
            this.lblCusBirth.TabIndex = 4;
            this.lblCusBirth.Text = "Ngày sinh:";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusPhone.Location = new System.Drawing.Point(133, 182);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(191, 26);
            this.txtCusPhone.TabIndex = 2;
            // 
            // lblCusPhone
            // 
            this.lblCusPhone.AutoSize = true;
            this.lblCusPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPhone.Location = new System.Drawing.Point(43, 188);
            this.lblCusPhone.Name = "lblCusPhone";
            this.lblCusPhone.Size = new System.Drawing.Size(56, 19);
            this.lblCusPhone.TabIndex = 4;
            this.lblCusPhone.Text = "Số ĐT:";
            // 
            // lblCusPoint
            // 
            this.lblCusPoint.AutoSize = true;
            this.lblCusPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusPoint.Location = new System.Drawing.Point(353, 42);
            this.lblCusPoint.Name = "lblCusPoint";
            this.lblCusPoint.Size = new System.Drawing.Size(102, 19);
            this.lblCusPoint.TabIndex = 4;
            this.lblCusPoint.Text = "Điểm tích lũy:";
            // 
            // txtCusBirth
            // 
            this.txtCusBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusBirth.Location = new System.Drawing.Point(133, 108);
            this.txtCusBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusBirth.Name = "txtCusBirth";
            this.txtCusBirth.Size = new System.Drawing.Size(191, 26);
            this.txtCusBirth.TabIndex = 2;
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusAddress.Location = new System.Drawing.Point(43, 150);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(61, 19);
            this.lblCusAddress.TabIndex = 4;
            this.lblCusAddress.Text = "Địa chỉ:";
            // 
            // txtCusINumber
            // 
            this.txtCusINumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusINumber.Location = new System.Drawing.Point(133, 219);
            this.txtCusINumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusINumber.Name = "txtCusINumber";
            this.txtCusINumber.Size = new System.Drawing.Size(191, 26);
            this.txtCusINumber.TabIndex = 2;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusName.Location = new System.Drawing.Point(43, 74);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(59, 19);
            this.lblCusName.TabIndex = 4;
            this.lblCusName.Text = "Họ tên:";
            // 
            // frmCustomer
            // 
            this.AcceptButton = this.btnCofirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 752);
            this.Controls.Add(this.pnThanhVien);
            this.Controls.Add(this.btnCofirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khách Hàng Thành Viên";
            this.pnThanhVien.ResumeLayout(false);
            this.pnThanhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCofirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnThanhVien;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.Button btnShowCustomer;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.NumericUpDown nudPoint;
        private System.Windows.Forms.Label lblCusID;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label lblCusINumber;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label lblCusBirth;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label lblCusPhone;
        private System.Windows.Forms.Label lblCusPoint;
        private System.Windows.Forms.TextBox txtCusBirth;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.TextBox txtCusINumber;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Button buttonchonphim;
    }
}