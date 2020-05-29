using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main
{
    public partial class MainClient : DevExpress.XtraEditors.XtraForm
    {
        public MainClient()
        {
            InitializeComponent();

            timer1.Start();
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue"; //Giao diện hiển thị đầu tiên
        }
        private void MainClient_Load(object sender, EventArgs e)
        {
            skins();
            System.Drawing.Rectangle workingRectangle =
        Screen.PrimaryScreen.WorkingArea;
            Console.WriteLine(workingRectangle.Width);
            Point p = new Point();

            p.X = workingRectangle.Width - this.Width;
            p.Y = 0;
            this.Location = p;
        }

        private void btnTinNhan_Click(object sender, EventArgs e)
        {
            Form frm_chat = new frm_chat();
            frm_chat.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-COPK1IA;Initial Catalog=QuanLyQuanNet01;Integrated Security=True";
                //Them ban ghi vao bang TaiKhoanMay de tinh thoi gian
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert_TaiKhoanMay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                if (con.State != ConnectionState.Open)
                    con.Open();
            cmd.Parameters.AddWithValue("@MaKH", "kh01");
            cmd.Parameters.AddWithValue("@MaMay", "may01");
                //cmd.Parameters.AddWithValue("@TaiKhoanMay", 1);
                cmd.Parameters.AddWithValue("@GioVao","0");
                cmd.Parameters.AddWithValue("@GioRa", DateTime.Now);
                cmd.ExecuteNonQuery();
                this.Hide();
            Form frm_login = new frm_Login();
            frm_login.Show();

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            Form frm_doimatkhau = new frm_DoiMatKhau();
            frm_doimatkhau.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
