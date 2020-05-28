using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlyquannet.DTO
{
    class Accounts
    {
        public Accounts(string maKH, string matKhau, double tien, int quyen)
        {
            this.MaKH = maKH;
            this.MatKhau = matKhau;
            this.Tien = tien;
            this.Quyen = quyen;
        }

        public Accounts(DataRow row)
        {
            this.MaKH = (string)row["MaKH"];
            this.MatKhau = row["MatKhau"].ToString();
            this.Tien = Convert.ToDouble(row["Tien"]);
            this.Quyen = (int)row["Quyen"];

        }

        private string maKH;
        private string matKhau;
        private double tien;
        private int quyen;

        public string MaKH { get => maKH; set => maKH = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public double Tien { get => tien; set => tien = value; }
        public int Quyen { get => quyen; set => quyen = value; }
    }
}
