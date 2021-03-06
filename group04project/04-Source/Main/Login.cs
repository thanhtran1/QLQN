﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Main
{
     
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        String maMayClient = "may01";
        public frm_Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-4ANTS40\SQLEXPRESS;Initial Catalog=QuanLyQuanNet01;Integrated Security=True";
            //Kiem tra tai khoan co ton tai
            string sql = "Select * from KhachHang where MaKH='" + txtTenDangNhap.Text + "' and  MatKhau='" + txtMatKhau.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               
                this.Hide();
                //Them ban ghi vao bang TaiKhoanMay de tinh thoi gian
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert_TaiKhoanMay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.Parameters.AddWithValue("@MaKH", txtTenDangNhap.Text);
                cmd.Parameters.AddWithValue("@MaMay", "may01");
                //cmd.Parameters.AddWithValue("@TaiKhoanMay", 1);
                cmd.Parameters.AddWithValue("@GioVao", DateTime.Now);
                cmd.Parameters.AddWithValue("@GioRa", DateTime.Now);

                timerTruTien.Start();

                cmd.ExecuteNonQuery();
                MainClient frmMain = new MainClient();
                frmMain.Show();
            }
            else
                MessageBox.Show("Kiem tra lai tai khoan, mat khau");
        }

        private void timerTruTien_Tick(object sender, EventArgs e)
        {
            double tienKH=tienKh();
            if(800<tienKH<1000)
            {
                MessageBox.Show("Thông báo","Tài khoản của bạn sắp hết.Xin vui lòng nạp thêm tiền vào tài khoản để sử dụng dịch vụ");
            }

            if(tienKH>0)
            {
                truTienKH();
                MessageBox.Show("Tien khach hang:" + tienKH.ToString());

               
            }else
            {
                timerTruTien.Stop();

                MessageBox.Show("Thông báo", "Tài khoản đã hết.Xin vui lòng nạp thêm tiền vào tài khoản để sử dụng dịch vụ");
                //Dang xuat
            }

        

        }

        private void truTienKH()
        {
            double gia = giaMay();
            double tienTru = gia/12;
            SqlCommand cmd = new SqlCommand("TruTien_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", txtTenDangNhap.Text);
            cmd.Parameters.AddWithValue("@tienTru", tienTru);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
            

        }

        private Double tienKh()
        {
            SqlCommand cmd = new SqlCommand("Tien_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", txtTenDangNhap.Text);
            DataTable dt = SQLDB.SQLDB.GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDouble(dt.Rows[0][0]);

            }
            else
                return 0;
        }

        private double giaMay()
        {
            SqlCommand cmd = new SqlCommand("GiaMay");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maMay", maMayClient);
            DataTable dt = SQLDB.SQLDB.GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDouble(dt.Rows[0][0]);

            }
            else
                return 0;
        }
    }
}