using GUI.DAO;
using GUI.DTO;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            LoadCustomer();

            dtgvCustomer.SelectionChanged += dtgvCustomer_SelectionChanged;

            txtCusID.KeyDown += txtCusID_KeyDown;
            txtCusName.KeyDown += txtCusName_KeyDown;
            txtCusBirth.KeyDown += txtCusBirth_KeyDown;
            txtCusAddress.KeyDown += txtCusAddress_KeyDown;
            txtCusPhone.KeyDown += txtCusPhone_KeyDown;
            txtCusINumber.KeyDown += txtCusINumber_KeyDown;
        }

        public Customer customer;
        public Customer customer1;
        public static Customer SelectedCustomer { get; private set; }

        BindingSource customerList = new BindingSource();
        void LoadCustomer()
        {
            dtgvCustomer.DataSource = customerList;
            LoadCustomerList();
            AddCustomerBinding();
        }

        void LoadCustomerList()
        {
            customerList.DataSource = CustomerDAO.GetListCustomer();
        }
        private void btnShowCustomer_Click_1(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void txtCusID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCusName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtCusName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCusBirth.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtCusBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCusAddress.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtCusAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCusPhone.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtCusPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCusINumber.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtCusINumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nudPoint.Focus();
                e.SuppressKeyPress = true;
            }
        }

        void AddCustomerBinding()
        {
            //txtCusID.DataBindings.Add("Text", dtgvCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            //txtCusName.DataBindings.Add("Text", dtgvCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            //txtCusBirth.DataBindings.Add("Text", dtgvCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            //txtCusAddress.DataBindings.Add("Text", dtgvCustomer.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            //txtCusPhone.DataBindings.Add("Text", dtgvCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            //txtCusINumber.DataBindings.Add("Text", dtgvCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            //nudPoint.DataBindings.Add("Value", dtgvCustomer.DataSource, "Điểm tích lũy", true, DataSourceUpdateMode.Never);
        
            // NGĂN KHÔNG CHO DATA TỰ ĐỘNG BIND VÀO TRONG TEXTBOX NỮA NHA BỦM
        }

        private void dtgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvCustomer.SelectedRows[0];
                txtCusID.Text = selectedRow.Cells["Mã khách hàng"].Value.ToString();
                txtCusName.Text = selectedRow.Cells["Họ tên"].Value.ToString();
                txtCusBirth.Text = selectedRow.Cells["Ngày sinh"].Value.ToString();
                txtCusAddress.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                txtCusPhone.Text = selectedRow.Cells["SĐT"].Value.ToString();
                txtCusINumber.Text = selectedRow.Cells["CMND"].Value.ToString();
                nudPoint.Value = Convert.ToDecimal(selectedRow.Cells["Điểm tích lũy"].Value);
            }
            else
            {
                txtCusID.Text = "KH";
                txtCusName.Text = "";
                txtCusBirth.Text = "";
                txtCusAddress.Text = "";
                txtCusPhone.Text = "";
                txtCusINumber.Text = "";
                nudPoint.Value = 0;
            }
        }

        void InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (CustomerDAO.InsertCustomer(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }
  

        void UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd, int point)
        {
            if (CustomerDAO.UpdateCustomer(id, hoTen, ngaySinh, diaChi, sdt, cmnd, point))
            {
                MessageBox.Show("Sửa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại");
            }
        }
        private void btnUpdateCustomer_Click_1(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            string cusName = txtCusName.Text;
            DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
            string cusAddress = txtCusAddress.Text;
            string cusPhone = txtCusPhone.Text;
            int cusINumber = Int32.Parse(txtCusINumber.Text);
            int cusPoint = (int)nudPoint.Value;
            UpdateCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber, cusPoint);
            LoadCustomerList();
        }

        void DeleteCustomer(string id)
        {
            if (CustomerDAO.DeleteCustomer(id))
            {
                MessageBox.Show("Xóa khách hàng thành công");
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại");
            }
        }
        private void btnDeleteCustomer_Click_1(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            DeleteCustomer(cusID);
            LoadCustomerList();
        }

        private void btnSearchCus_Click_1(object sender, EventArgs e)
        {
            string cusName = txtSearchCus.Text;
            customerList.DataSource = CustomerDAO.SearchCustomerByName(cusName);
        }

        private void txtSearchCus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchCus.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnAddCustomer_Click_1(object sender, EventArgs e)
        {
            string cusID = txtCusID.Text;
            string cusName = txtCusName.Text;
            DateTime cusBirth = DateTime.Parse(txtCusBirth.Text);
            string cusAddress = txtCusAddress.Text;
            string cusPhone = txtCusPhone.Text;
            int cusINumber = Int32.Parse(txtCusINumber.Text);
            InsertCustomer(cusID, cusName, cusBirth, cusAddress, cusPhone, cusINumber);
            LoadCustomerList();

        }

        private void buttonchonphim_Click(object sender, EventArgs e)
        {
            DataTable data = CustomerDAO.GetCustomerMember(txtCusID.Text, txtCusName.Text);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ID hoặc Họ tên của Khách Hàng không chính xác!\nVui lòng nhập lại thông tin.");
                return;
            }
            //customer1 = new Customer(data.Rows[0]);
            SelectedCustomer = new Customer(data.Rows[0]);
            DialogResult = DialogResult.OK;
           

            this.Close();
            frmSeller frm = new frmSeller();
            frm.ShowDialog();
            this.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            txtCusID.Text = "KH";
            txtCusName.Clear();
            txtCusBirth.Clear();
            txtCusAddress.Clear();
            txtCusPhone.Clear();
            txtCusINumber.Clear();
            nudPoint.Value = 0;
        }
    }
}
