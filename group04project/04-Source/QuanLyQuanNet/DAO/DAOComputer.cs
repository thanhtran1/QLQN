using Quanlyquannet.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquannet.DAO
{
    class DAOComputer
    {
        public static void DeleteComputer(string id)
        {
            SqlCommand cmd = new SqlCommand("Delete_May");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMay", id);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);


        }

        public static bool searchComputer(string id)
        {
            SqlCommand cmd = new SqlCommand("Search_May");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMay", id);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static List<Computer> SearchComputerByName(string name)
        {

            List<Computer> computerList = new List<Computer>();
            SqlCommand cmd = new SqlCommand("SearchThongTin_May");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenMay", name);
            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            foreach (DataRow item in dt.Rows)
            {
                Computer computer = new Computer(item);
                computerList.Add(computer);

            }

            return computerList;


        }


        public static void UpdateComputer(string maMay, string tenMay, double giaTien)
        {
            SqlCommand cmd = new SqlCommand("Update_May");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMay", maMay);
            cmd.Parameters.AddWithValue("@tenMay", tenMay);
            cmd.Parameters.AddWithValue("@trangThai", false);
            cmd.Parameters.AddWithValue("@giaTien", giaTien);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);

        }

        public static List<Computer> LoadComputerList()
        {
            List<Computer> computerList = new List<Computer>();
            SqlCommand cmd = new SqlCommand("ThongTin_May");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            foreach (DataRow item in dt.Rows)
            {
                Computer computer = new Computer(item);
                computerList.Add(computer);

            }

            return computerList;
        }

        public static void InsertComputer(string maMay, string tenMay, double giaTien)
        {
            SqlCommand cmd = new SqlCommand("Insert_May");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMay", maMay);
            cmd.Parameters.AddWithValue("@tenMay", tenMay);
            cmd.Parameters.AddWithValue("@trangThai", false);
            cmd.Parameters.AddWithValue("@giaTien", giaTien);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);



        }

    }
}
