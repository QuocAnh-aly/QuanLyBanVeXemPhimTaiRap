using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls.DataUserControl
{
    public partial class FilmUC : UserControl
    {
        public string id;
        private string tenPhim;
        public FilmUC()
        {
            InitializeComponent();

        }

        public string TenPhim
        {
            get => tenPhim;
            set
            {
                tenPhim = value;
                labeltenfilm.Text = value; // lblTenPhim là Label trên UC để hiển thị tên
            }
        }

        private Image anhPhim;
        public Image AnhPhim
        {
            get => anhPhim;
            set
            {
                anhPhim = value;
                picturefilm.Image = value; // picPoster là PictureBox trên UC
                picturefilm.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void buttondatve_Click_1(object sender, EventArgs e)
        {
            frmSeller frm = new frmSeller(tenPhim);
            frm.ShowDialog();
        }
    }
}
