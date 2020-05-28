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
using Quanlyquannet.DAO;

namespace Quanlyquannet.Views
{
    public partial class frm_QuanLyMay : DevExpress.XtraEditors.XtraForm
    {
        BindingSource computerList = new BindingSource();
        public frm_QuanLyMay()
        {
            InitializeComponent();
            dgvQuanLyMay.DataSource = computerList;
            refeshComputer();

        }
        #region  method
        private void addComputerBinding()
        {
            clearBinding();
            txtMaMay.DataBindings.Add(new Binding("Text", dgvQuanLyMay.DataSource, "MaMay", true, DataSourceUpdateMode.Never));
            txtTenMay.DataBindings.Add(new Binding("Text", dgvQuanLyMay.DataSource, "TenMay", true, DataSourceUpdateMode.Never));
            numGiaTien.DataBindings.Add(new Binding("Value", dgvQuanLyMay.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));
        }

        private void clearBinding()
        {
            txtMaMay.DataBindings.Clear();
            txtTenMay.DataBindings.Clear();
            numGiaTien.DataBindings.Clear();
        }

        private void loadComputer()
        {

            dgvQuanLyMay.DataSource = DAO.DAOComputer.LoadComputerList();

            dgvQuanLyMay.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvQuanLyMay.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvQuanLyMay.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgvQuanLyMay.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);

            dgvQuanLyMay.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvQuanLyMay.Columns[0].HeaderText = "Mã máy";
            dgvQuanLyMay.Columns[1].HeaderText = "Tên  máy";
            dgvQuanLyMay.Columns[2].HeaderText = "Trạng Thái máy";
            dgvQuanLyMay.Columns[3].HeaderText = "Giá tiền (VNĐ)";


        }


        private void refeshComputer()
        {
            loadComputer();
            addComputerBinding();
        }


        #endregion

        #region  event
        

        private void btnThemMay_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maMay = txtMaMay.Text;
                string tenMay = txtTenMay.Text;
                double giaTien = Convert.ToDouble(numGiaTien.Value);

                DAO.DAOComputer.InsertComputer(maMay, tenMay, giaTien);
                MessageBox.Show("Thêm máy thành công!", "Thông báo!");
                refeshComputer();

            }
            catch
            {
                MessageBox.Show("Mã máy đã tồn tại.Thêm máy thất bại", "Thông báo!");
                refeshComputer();
            }

        }

        private void btnSuaMay_Click_1(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            double giaTien = Convert.ToDouble(numGiaTien.Value);
            if (DAO.DAOComputer.searchComputer(maMay))
            {
                DAO.DAOComputer.UpdateComputer(maMay, tenMay, giaTien);
                MessageBox.Show("Sửa máy thành công!", "Thông báo!");
                refeshComputer();

            }
            else
            {
                MessageBox.Show("Mã " + maMay + " không tồn tại!", "Thông báo!");
                refeshComputer();
            }

        }

        private void btnXoaMay_Click_1(object sender, EventArgs e)
        {
            string maMay = txtMaMay.Text;
            string tenMay = txtTenMay.Text;
            if (MessageBox.Show("Bạn có muốn xóa " + tenMay + " không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DAO.DAOComputer.DeleteComputer(maMay);
                MessageBox.Show("Xóa " + tenMay + " thành công!", "Thông báo!");
                refeshComputer();


            }

        }

        private void btnLamMoiMay_Click(object sender, EventArgs e)
        {
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            numGiaTien.Value = numGiaTien.Minimum;
            refeshComputer();

        }

        private void btnTimKiemMay_Click(object sender, EventArgs e)
        {
            computerList.DataSource = DAOComputer.SearchComputerByName(txtTimKiemMay.Text);
            dgvQuanLyMay.DataSource = computerList;
            addComputerBinding();

        }
        #endregion
    }
}