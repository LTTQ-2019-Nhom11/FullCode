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
    public partial class formCheBien : DevExpress.XtraEditors.XtraForm
    {
        private int dgvrowNL;
        private int dgvrow;
        private int sl;
        public formCheBien()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvCheBien.DataSource = db.getData("select TenThucDon, SoLuong, XacNhan, tblGoiMon1.MaThucDon from tblGoiMon1 join tblThucDon on tblGoiMon1.MaThucDon=tblThucDon.MaThucDon where MaBanAn=" + cbChonBan.Text);
            dgvNLHuy.DataSource = db.getData("select TenNL from tblYeuCauNL join tblNguyenLieu on tblYeuCauNL.MaNL=tblNguyenLieu.MaNL where XacNhan=N'Hủy' group by tblYeuCauNL.MaNL, TenNL");
            
        }
        private void FormCheBien_Load(object sender, EventArgs e)
        {
            
            myDataBases db = new myDataBases();
            dgvNguyenLieu.DataSource = db.getData("select TenNL, TenNCC, SoLuong, HoTen, DonViTinh, DonGia, MaNL, tblNguyenLieu.MaNCC from tblNguyenLieu join tblNCC on tblNguyenLieu.MaNCC=tblNCC.MaNCC join tblNguoiDung on tblNguoiDung.MaNguoiDung=tblNguyenLieu.MaNVNhap");
            dgvNLHuy.DataSource = db.getData("select TenNL from tblYeuCauNL join tblNguyenLieu on tblYeuCauNL.MaNL=tblNguyenLieu.MaNL where XacNhan=N'Hủy' group by tblYeuCauNL.MaNL, TenNL");
            DataTable dt = db.getData("select distinct MaBanAn from tblGoiMon1");
            foreach (DataRow dr in dt.Rows)
            {
                cbChonBan.Items.Add(dr["MaBanAn"].ToString());
            }
        }
        private void CbChonBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void BtnXong_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                db.executeQuery("update tblGoiMon1 set XacNhan=N'Xong' where MaBanAn=" + cbChonBan.Text + "and XacNhan != N'Hủy'");
                refreshDataGridView();
                MessageBox.Show("Xác nhận thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn bàn!");
            }
        }

        private void DgvCheBien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvrow = e.RowIndex;
        }

        private void BtnHuyMon_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                db.executeQuery("update tblGoiMon1 set XacNhan=N'Hủy' where MaBanAn="+cbChonBan.Text+" and MaThucDon='"+dgvCheBien.Rows[dgvrow].Cells[3].Value.ToString()+"'");
                refreshDataGridView();
                MessageBox.Show("Hủy món thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn bàn!");
            }
        }

        private void DgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvrowNL = e.RowIndex;
            if (dgvrowNL >= 0)
            {
                textTenNL.Text = dgvNguyenLieu.Rows[dgvrowNL].Cells[0].Value.ToString();
                textSoLuong.Text = dgvNguyenLieu.Rows[dgvrowNL].Cells[2].Value.ToString();
                sl = int.Parse(textSoLuong.Text);
            }
            myDataBases db = new myDataBases();
            dgvNLHuy.DataSource = db.getData("select TenNL from tblYeuCauNL join tblNguyenLieu on tblYeuCauNL.MaNL=tblNguyenLieu.MaNL where XacNhan=N'Hủy'");
        }

        private void BtnYeuCau_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textSoLuong.Text) < sl)
                {
                    myDataBases db = new myDataBases();
                    db.executeQuery("insert into tblYeuCauNL values ('" + dgvNguyenLieu.Rows[dgvrowNL].Cells[6].Value.ToString() + "'," + textSoLuong.Text + ",N'Chưa')");
                    MessageBox.Show("Yêu cầu thành công!");
                } else
                {
                    MessageBox.Show("Số lượng yêu cầu quá lớn!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thành công!");
            }
        }
    }
}