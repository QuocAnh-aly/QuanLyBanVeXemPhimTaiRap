using GUI.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAO
{
    internal class PrintTicketDAO
    {
        //public static List<PrintTK> GetListTicketsByShowTimes(string showTimesID)
        //{
        //    List<PrintTK> listTicket = new List<PrintTK>();
        //    string query = "select * from Ve where idLichChieu = '" + showTimesID + "'";
        //    DataTable data = DataProvider.ExecuteQuery(query);
        //    foreach (DataRow row in data.Rows)
        //    {
        //        PrintTK printtk = new PrintTK(row);
        //        listTicket.Add(printtk);
        //    }
        //    return listTicket;
        //}
        //public static List<PrintTK> GetSeatsByCustomerID(string showTimeID, string customerID)
        //{
        //    List<PrintTK> seats = new List<PrintTK>();

        //    string query = "SELECT MaGheNgoi FROM dbo.Ve WHERE ShowTimeID = ' "+showTimeID+"' AND CustomerID = '"+ customerID+"'";

        //    DataTable data = DataProvider.ExecuteQuery(query);

        //    foreach (DataRow row in data.Rows)
        //    {
        //        PrintTK sek = new PrintTK(row);
        //        seats.Add(sek);
        //    }

        //    return seats;
        //}
        public static List<PrintTK> GetListTicketsByShowTimes(string showTimesID)
        {
            List<PrintTK> listTicket = new List<PrintTK>();
            string query = "SELECT * FROM Ve WHERE idLichChieu = @showTimesID";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@showTimesID", SqlDbType.NVarChar) { Value = showTimesID }
            };

            DataTable data = DataProvider.ExecuteQuery(query, parameters);
            foreach (DataRow row in data.Rows)
            {
                PrintTK printtk = new PrintTK(row);
                listTicket.Add(printtk);
            }
            return listTicket;
        }

        public static List<string> GetSeatsByCustomerID(string showTimeID, string customerID)
        {
            List<string> seats = new List<string>();

            string query = "SELECT MaGheNgoi FROM dbo.Ve WHERE idLichChieu = @showTimeID AND idKhachHang = @customerID";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@showTimeID", SqlDbType.NVarChar) { Value = showTimeID },
        new SqlParameter("@customerID", SqlDbType.NVarChar) { Value = customerID }
            };

            DataTable data = DataProvider.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                seats.Add(row["MaGheNgoi"].ToString());
            }

            return seats;
        }


    }
}
