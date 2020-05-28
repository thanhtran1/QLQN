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
    public partial class frm_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        //Tạo đối tượng kết nối
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-COPK1IA;Initial Catalog=QuanLyQuanNet01;Integrated Security=True");
                
        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        { 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-COPK1IA;Initial Catalog=QuanLyQuanNet01;Integrated Security=True";   
            string sql = "Select * from KhachHang where MaKH = '" + txtTenTaiKhoan.Text + "'and MatKhau = '" + txtMatKhauHienTai.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(dt);   
            dxErrorProvider1.ClearErrors();
            if (dt.Rows.Count > 0)
            {
                if (txtMatKhauMoi.Text == txtNhapLaiMatKhauMoi.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update KhachHang set MatKhau = '" + txtMatKhauMoi.Text + "' where MaKH = '" + txtTenTaiKhoan.Text + "'and MatKhau = '" + txtMatKhauHienTai.Text + "'", con);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dxErrorProvider1.SetError(txtMatKhauMoi, "Bạn chưa điền mật khẩu mới");
                    dxErrorProvider1.SetError(txtNhapLaiMatKhauMoi, "Mật khẩu nhập lại chưa đúng!");
                }
            }
            else
            {
                dxErrorProvider1.SetError(txtTenTaiKhoan, "Tên tài khoản không đúng");
                dxErrorProvider1.SetError(txtMatKhauHienTai, "Mật khẩu hiện tại không đúng");
            }    
            
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
