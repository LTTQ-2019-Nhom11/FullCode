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
    public partial class formXuatNL : DevExpress.XtraEditors.XtraForm
    {
        private int dgvrowNL;
        private int dgvrow=0;
        private int rowNhapNL=0;
        private string maNL="";
        private string maNL_Nhap = "";
        public formXuatNL()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvYeuCauNL.DataSource = db.getData("select tblYeuCauNL.MaNL, TenNL, SUM(tblYeuCauNL.SoLuong) as SoLuong, DonGia, DonViTinh, XacNhan from tblYeuCauNL join tblNguyenLieu on tblYeuCauNL.MaNL  = tblNguyenLieu.MaNL group by tblYeuCauNL.MaNL, tblYeuCauNL.MaNL, TenNL, DonGia, DonViTinh, XacNhan");
            dgvNguyenLieu.DataSource = db.getData("select TenNL, TenNCC, SoLuong, HoTen, DonViTinh, DonGia, MaNL, tblNguyenLieu.MaNCC from tblNguyenLieu join tblNCC on tblNguyenLieu.MaNCC=tblNCC.MaNCC join tblNguoiDung on tblNguoiDung.MaNguoiDung=tblNguyenLieu.MaNVNhap");
            dgvYeuCauMua.DataSource = db.getData("select tblYC_MuaNL.MaNL, TenNL, SUM(tblYC_MuaNL.SoLuong) as SoLuong, DonGia, DonViTinh, XacNhan from tblYC_MuaNL join tblNguyenLieu on tblYC_MuaNL.MaNL  = tblNguyenLieu.MaNL where XacNhan=N'Chấp Nhận' group by tblYC_MuaNL.MaNL, tblYC_MuaNL.MaNL, TenNL, DonGia, DonViTinh, XacNhan");
        }
        private void FormXuatNL_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void DgvYeuCauNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvrowNL = e.RowIndex;
            if (dgvrowNL >= 0)
            {
                textTenNL.Text = dgvYeuCauNL.Rows[dgvrowNL].Cells[1].Value.ToString();
                textSoLuong.Text = dgvYeuCauNL.Rows[dgvrowNL].Cells[2].Value.ToString();
            }
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            maNL = dgvYeuCauNL.Rows[dgvrowNL].Cells[0].Value.ToString();
            myDataBases db = new myDataBases();
            db.executeQuery("insert into tblXuatNL values ('" + maNL + "','" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "'," + textSoLuong.Text + ")");
            db.executeQuery("update tblNguyenLieu set SoLuong=SoLuong-" + textSoLuong.Text + " where MaNL='" + maNL + "'");
            db.executeQuery("delete from tblYeuCauNL where MaNL='" + maNL + "'");
            refreshDataGridView();
            MessageBox.Show("Xuất nguyên liệu thành công!");
            dgvrowNL = 0;
        }

        private void DgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvrow = e.RowIndex;
            if (dgvrow >= 0)
            {
                textTenNL1.Text = dgvNguyenLieu.Rows[dgvrow].Cells[0].Value.ToString();
            }
        }

        private void BtnYeuCau_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                db.executeQuery("insert into tblYC_MuaNL values ('"+ dgvNguyenLieu.Rows[dgvrow].Cells[6].Value.ToString() +"',"+textSoLuong1.Text+",N'Chưa')");
                MessageBox.Show("Yêu cầu thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thành công!");
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            db.executeQuery("update tblYeuCauNL set XacNhan=N'Hủy' where MaNL='" + maNL + "'");
            refreshDataGridView();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            maNL_Nhap = dgvYeuCauMua.Rows[rowNhapNL].Cells[0].Value.ToString();
            myDataBases db = new myDataBases();
            db.executeQuery("insert into tblNhapNL values ('" + maNL_Nhap + "','" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "'," + dgvYeuCauMua.Rows[rowNhapNL].Cells[2].Value.ToString() + ", N'Đã Nhận, Chưa Thanh Toán Tiền')");
            db.executeQuery("update tblNguyenLieu set SoLuong=SoLuong+" + dgvYeuCauMua.Rows[rowNhapNL].Cells[2].Value.ToString() + " where MaNL='" + maNL_Nhap + "'");
            db.executeQuery("delete from tblYC_MuaNL where MaNL='" + maNL_Nhap + "'");
            MessageBox.Show("Đã xác nhận nhập nguyên liệu thành công!");
            refreshDataGridView();
            rowNhapNL = 0;

        }

        private void DgvYeuCauMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowNhapNL = e.RowIndex;
        }
    }
}