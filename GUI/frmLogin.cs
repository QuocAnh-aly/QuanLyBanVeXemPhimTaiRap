using System;
using System.Windows.Forms;
using GUI.DAO;
using GUI.DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            int result = Login(userName, passWord);

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo");
                return;
            }
            else
            {
                if (result == 1)
                {
                    Account loginAccount = AccountDAO.GetAccountByUserName(userName);
                    this.Hide();
                    frmDashBoard frm = new frmDashBoard(loginAccount);
                    frm.ShowDialog();
                    this.Show();
                }
                else if (result == 0)
                {
                    MessageBox.Show("SAI TÊN TÀI KHOẢN HOẶC MẬT KHẨU!!!!", "THÔNG BÁO");
                    txtPassword.Clear();
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
                }
            }
        }

        private int Login(string userName, string passWord)
        {
            return AccountDAO.Login(userName, passWord);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void mnuSetting_Click(object sender, EventArgs e)
        {
            //frm.ShowDialog();
        }

        private void PassChanging_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PassChanging_checkbox.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
