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
    class DAOTaiKhoanMay
    {
        public static TaiKhoanMay ThongTinTaiKhoanMay(string MaMay, DateTime thoiGian)
        {
            TaiKhoanMay temp = new TaiKhoanMay();
            SqlCommand cmd = new SqlCommand("ThongTin_TaiKhoanMay_HoatDong");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMay", MaMay);
            cmd.Parameters.AddWithValue("@thoigian", thoiGian);

            DataTable dt = new DataTable();

            dt = SQLDB.SQLDB.GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    temp = new TaiKhoanMay(item);
                }

            }
            return temp;

        }

    }
}
