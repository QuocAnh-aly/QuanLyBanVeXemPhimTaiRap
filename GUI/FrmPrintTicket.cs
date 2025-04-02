using GUI.DAO;
using GUI.DTO;
using GUI.frmAdminUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrintTicket : Form
    {
        ShowTimes times;
        Movie movies;
        Customer customer1;
        List<string> paidSeats;
        public FrmPrintTicket(ShowTimes showTimes, Movie movie, List<string> paidSeats)
        {
            InitializeComponent();
            times = showTimes;
            movies = movie;

            this.paidSeats = paidSeats;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrintTicket_Load(object sender, EventArgs e)
        {

            labelinforfilm.Text = "CGV Hung Vuong | " + times.CinemaName + " | " + times.MovieName;
            labelinfortime.Text = times.Time.ToShortDateString() + " | "
                + times.Time.ToShortTimeString() + " - "
                + times.Time.AddMinutes(movies.Time).ToShortTimeString();
           
           
          
            if (frmCustomer.SelectedCustomer != null)
            {
                customer1 = frmCustomer.SelectedCustomer;
                labelinforcustomer.Text = customer1.Name;
                labelinforidkh.Text = customer1.ID;
               
            }
            if (paidSeats != null && paidSeats.Count > 0)
            {
                labelinforghe.Text = "Ghế đã thanh toán: " + string.Join(", ", paidSeats);
            }
            else
            {
                labelinforghe.Text = "Không có ghế nào được thanh toán.";
            }


        }

        private void labelinforghe_Click(object sender, EventArgs e)
        {

        }

        private void labelinforphong_Click(object sender, EventArgs e)
        {

        }
    }
}
