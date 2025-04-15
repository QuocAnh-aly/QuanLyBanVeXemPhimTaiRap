using GUI.DTO;
using GUI.frmAdminUserControls.DataUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmFilm : Form
    {
        private List<Movie> danhSachPhim = new List<Movie>();

        public frmFilm()
        {
            InitializeComponent();
        }


        private void frmFilm_Load(object sender, EventArgs e)
        {
            dtpThoiGianphim.Value = DateTime.Now;
            LoadPhimTheoNgay(dtpThoiGianphim.Value);
        }

        private void dtpThoiGianphim_ValueChanged(object sender, EventArgs e)
        {
            LoadPhimTheoNgay(dtpThoiGianphim.Value);
        }
        private string connectionString = "Data Source=LAPTOP-QHOF49SH;Initial Catalog = QLRP; User ID = quocanh_Aly; Password=hellohi333z777";
        private void LoadPhimTheoNgay(DateTime ngay)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                string query = "SELECT * FROM Phim WHERE @ngay <= NgayKetThuc";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        string tenPhim = row["TenPhim"].ToString();
                        byte[] byteAnh = (byte[])row["ApPhich"];
                        Image anhPhim = Image.FromStream(new MemoryStream(byteAnh));
                        string idPhim = row["ID"].ToString();

                        ThemPhim(tenPhim, anhPhim, idPhim);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải phim: " + ex.Message);
            }
        }

        private void ThemPhim(string ten, Image anh, string id)
        {
            var filmUC = new FilmUC
            {
                id = id,
                TenPhim = ten,
                AnhPhim = anh
            };
            flowLayoutPanel1.Controls.Add(filmUC);
        }
    }
}
