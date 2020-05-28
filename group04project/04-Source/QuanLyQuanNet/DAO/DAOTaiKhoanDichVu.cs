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
    class DAOTaiKhoanDichVu
    {

        public static List<TaiKhoanDichVu> LoadComputerList(string maMay)
        {
            List<TaiKhoanDichVu> danhsach = new List<TaiKhoanDichVu>();
            SqlCommand cmd = new SqlCommand("ThongTin_TaiKhoanDichVu_HoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMay", maMay);
            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);

            foreach (DataRow item in dt.Rows)
            {
                TaiKhoanDichVu temp = new TaiKhoanDichVu(item);
                danhsach.Add(temp);

            }
            return danhsach;
        }


    }
}
