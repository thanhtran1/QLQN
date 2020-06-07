using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Quanlyquannet.Views;
using Quanlyquannet.DTO;

namespace Quanlyquannet
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            loadComputer();
        }

        #region Giang code 
        private void loadComputer()
        {

            List<Computer> computerList = DAO.DAOComputer.LoadComputerList();

            foreach (Computer item in computerList)
            {
                Button btn = new Button() { Width = 180, Height = 180 };
                btn.Image = Quanlyquannet.Properties.Resources.Devices_computer_icon21;
                btn.Tag = item;
                btn.Click += btn_Click;
                btn.TextAlign = ContentAlignment.BottomCenter;

                btn.Font = new Font("Arial", 16, FontStyle.Bold);
                btn.Text = item.TenMay;
                if (item.TrangThai)
                {
                    btn.BackColor = Color.LightBlue;
                    btn.ForeColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.DarkGray;
                    btn.ForeColor = Color.Black;
                }
                flpDanhSachMay.Controls.Add(btn);
            }


        }
        private void btn_Click(object sender, EventArgs e)
        {
            string maMay = ((sender as Button).Tag as Computer).MaMay;
            grvTaiKhoanDichVuMain.Tag = (sender as Button).Tag;

            loadThongTinTaiKhoanMay(maMay);
            loadDichVuMay(maMay);

        }

        private void loadDichVuMay(string maMay)
        {
            List<TaiKhoanDichVu> danhsach = DAO.DAOTaiKhoanDichVu.LoadComputerList(maMay);
            grvTaiKhoanDichVuMain.DataSource = danhsach;

            grvTaiKhoanDichVuMain.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            grvTaiKhoanDichVuMain.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            grvTaiKhoanDichVuMain.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
            grvTaiKhoanDichVuMain.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);

            grvTaiKhoanDichVuMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grvTaiKhoanDichVuMain.Columns[0].HeaderText = "Tên  dịch vụ";
            grvTaiKhoanDichVuMain.Columns[1].HeaderText = " Đơn giá  ";
            grvTaiKhoanDichVuMain.Columns[2].HeaderText = "Số lượng";
            grvTaiKhoanDichVuMain.Columns[3].HeaderText = "Tổng tiền (VNĐ)";

            double sum = 0;
            foreach (TaiKhoanDichVu item in danhsach)
            {


                sum += item.TongTien;

            }
            lbPhiDichVu.Text = Convert.ToString(sum) + " đ";

        }

        private void loadThongTinTaiKhoanMay(string maMay)
        {
            TaiKhoanMay thongTin = DAO.DAOTaiKhoanMay.ThongTinTaiKhoanMay(maMay, DateTime.Now);

            if (thongTin.ThoiGianSuDung > 0)
            {
                lbTaiKhoan.Text = thongTin.MaKH;
                lbGioVao.Text = Convert.ToString(thongTin.GioVao);
                lbThoiGianSuDung.Text = Convert.ToInt32(thongTin.ThoiGianSuDung) / 60 + " giờ " + thongTin.ThoiGianSuDung % 60 + " phút";
            }
            else
            {
                lbTaiKhoan.Text = "";
                lbGioVao.Text = "";
                lbThoiGianSuDung.Text = "";
            }

        }


        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnNapTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_NapTien = new frm_NapTien();
            frm_NapTien.ShowDialog();
        }

        private void tabHienThi_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát khỏi hệ thống ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

     
        private void numericChartRangeControlClient3_CustomizeSeries(object sender, ClientDataSourceProviderCustomizeSeriesEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnQuanLyMay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_QuanLyMay = new frm_QuanLyMay();
            frm_QuanLyMay.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ThongKeDoanhThu = new frm_ThongKeDoanhThu();
            frm_ThongKeDoanhThu.ShowDialog();
        }

        private void bbtnGioSuDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ThongKeGioSuDung = new frm_ThongKeGioSuDung();
            frm_ThongKeGioSuDung.ShowDialog();
        }

        private void bbtnDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_ThongKeDichVu = new frm_ThongKeDichVu();
            frm_ThongKeDichVu.ShowDialog();
        }

        private void bbtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbtnQuanLyTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_QuanLyTaiKhoan = new frm_QuanLyTaiKhoan();
            frm_QuanLyTaiKhoan.ShowDialog();
        }

        private void bbtnQuanLyDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm_QuanLyDichVu = new frm_QuanLyDichVu();
            frm_QuanLyDichVu.ShowDialog();
        }

        private void lbThoiGianSuDung_Click(object sender, EventArgs e)
        {
            
        }

        private void lbTaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}
