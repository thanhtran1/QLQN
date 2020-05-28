using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquannet.DTO
{
    class TaiKhoanMay
    {


        private string maKH;
        private DateTime gioVao;
        private double thoiGianSuDung;

        public TaiKhoanMay(string maKH, DateTime gioVao, double thoiGianSuDung)
        {
            this.MaKH = maKH;
            this.GioVao = gioVao;
            this.ThoiGianSuDung = thoiGianSuDung;



        }
        public TaiKhoanMay()
        {

        }

        public TaiKhoanMay(DataRow row)
        {
            this.MaKH = (string)row["MaKH"];
            this.GioVao = Convert.ToDateTime(row["GioVao"]);
            this.ThoiGianSuDung = Convert.ToDouble(row["ThoiGianSuDung"]);
        }


        public DateTime GioVao { get => gioVao; set => gioVao = value; }
        public double ThoiGianSuDung { get => thoiGianSuDung; set => thoiGianSuDung = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
