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

namespace PhanMemQuanLyNhaHang.Views
{
    public partial class formThanhToanNL : DevExpress.XtraEditors.XtraForm
    {
        private int row = 0;
        private string MaNL = "";
        public formThanhToanNL()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvThanhToan.DataSource = db.getData("select tblNhapNL.MaNL, TenNL, tblNhapNL.SoLuong, NgayNhap, DonGia, DonViTinh, XacNhan from tblNhapNL join tblNguyenLieu on tblNhapNL.MaNL  = tblNguyenLieu.MaNL where XacNhan=N'Đã Nhận, Chưa Thanh Toán Tiền'");
        }

        private void FormThanhToanNL_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            MaNL = dgvThanhToan.Rows[row].Cells[0].Value.ToString();
            myDataBases db = new myDataBases();
            db.executeQuery("update tblNhapNL set XacNhan=N'Đã Thanh Toán' where MaNL='" + MaNL + "'");
            MessageBox.Show("Đã xác nhận nhập nguyên liệu thành công!");
            refreshDataGridView();
            row = 0;
        }

        private void DgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
    }
}