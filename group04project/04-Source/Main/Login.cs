using System;
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
            con.ConnectionString = @"Data Source=DESKTOP-COPK1IA;Initial Catalog=QuanLyQuanNet01;Integrated Security=True";
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
                cmd.ExecuteNonQuery();
                MainClient frmMain = new MainClient();
                frmMain.Show();
            }
            else
                MessageBox.Show("Kiem tra lai tai khoan, mat khau");
        }
    }
}