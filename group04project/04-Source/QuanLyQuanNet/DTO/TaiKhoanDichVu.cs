using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquannet.DTO
{
    class TaiKhoanDichVu
    {
        private string tenDichVu;
        private double donGia;
        private int soLuong;
        private double tongTien;

        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }

        public TaiKhoanDichVu(string tenDichVu, float donGia, int soLuong, float tongTien)
        {
            this.TenDichVu = tenDichVu;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.TongTien = tongTien;
        }
        public TaiKhoanDichVu()
        {

        }

        public TaiKhoanDichVu(DataRow row)
        {
            this.TenDichVu = (string)row["TenDV"];
            this.DonGia = Convert.ToDouble(row["DonGia"]);
            this.SoLuong = Convert.ToInt32(row["SoLuong"]);
            this.TongTien = Convert.ToDouble(row["TongTien"]);
        }


    }
}
