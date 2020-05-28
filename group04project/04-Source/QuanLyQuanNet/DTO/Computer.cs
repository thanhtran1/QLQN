using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquannet.DTO
{
    class Computer
    {
        public Computer(string maMay, string tenMay, bool trangThai, double giaTien)
        {
            this.MaMay = maMay;
            this.TenMay = tenMay;
            this.TrangThai = trangThai;
            this.GiaTien = giaTien;
        }
        public Computer(DataRow row)
        {
            this.MaMay = (string)row["MaMay"];
            this.TenMay = row["TenMay"].ToString();
            this.TrangThai = (bool)row["TrangThai"];
            this.GiaTien = Convert.ToDouble(row["Gia"]);
        }
        private string tenMay;
        private bool trangThai;
        private string maMay;
        private double giaTien;

        public string MaMay { get => maMay; set => maMay = value; }
        public string TenMay { get => tenMay; set => tenMay = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public double GiaTien { get => giaTien; set => giaTien = value; }
    }
}
