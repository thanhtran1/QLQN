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
using System.Security.Cryptography;

namespace Quanlyquannet.Views
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (kiemTra(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                Form frm_Main = new frmMain();
                frm_Main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không chính xác!");

            }
        }
        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Blue"; //Giao diện hiển thị đầu tiên
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            skins();
        }
        
        private void textMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }
        private bool kiemTra(string userName, string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach (byte item in hashData)
            {
                hashPass += item;
            }
            return DAO.DAOAccounts.ThongTin_Account_ByIDPass(userName, hashPass);

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}