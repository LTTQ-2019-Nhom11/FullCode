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
    public partial class formNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public string kt = "";
        public string MaNL = "";
        private int numrow=0;
        public formNguyenLieu()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvNguyenLieu.DataSource = db.getData("select TenNL, TenNCC, SoLuong, HoTen, DonViTinh, DonGia, MaNL, tblNguyenLieu.MaNCC from tblNguyenLieu join tblNCC on tblNguyenLieu.MaNCC=tblNCC.MaNCC join tblNguoiDung on tblNguoiDung.MaNguoiDung=tblNguyenLieu.MaNVNhap");
        }
        private void setControls(bool s)
        {
            btnThem.Enabled = s;
            btnSua.Enabled = s;
            btnXoa.Enabled = s;
            btnSave.Enabled = !s;
            btnCancel.Enabled = !s;

            textTenNL.Enabled = !s;
            cbMaNCC.Enabled = !s;
            //dateNgayNhap.Enabled = !s;
            textSoLuong.Enabled = !s;
            textDonViTinh.Enabled = !s;
            textDonGia.Enabled = !s;
        }
        private void FormNguyenLieu_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            if (formLogin.quyen.ToString() == "Giám Đốc")
            {
                btnSave.Visible = true;
                btnCancel.Visible = true;
                grXuLy.Visible = true;
            }
            myDataBases db = new myDataBases();
            DataTable dt = db.getData("select distinct MaNCC from tblNCC");
            foreach (DataRow dr in dt.Rows)
            {
                cbMaNCC.Items.Add(dr["MaNCC"].ToString());
            }
        }

        private void DgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                textTenNL.Text = dgvNguyenLieu.Rows[numrow].Cells[0].Value.ToString();
                cbMaNCC.Text = dgvNguyenLieu.Rows[numrow].Cells[7].Value.ToString();
                textSoLuong.Text = dgvNguyenLieu.Rows[numrow].Cells[2].Value.ToString();
                textNguoiNhap.Text = dgvNguyenLieu.Rows[numrow].Cells[3].Value.ToString();
                textDonViTinh.Text = dgvNguyenLieu.Rows[numrow].Cells[4].Value.ToString();
                textDonGia.Text = dgvNguyenLieu.Rows[numrow].Cells[5].Value.ToString();
                MaNL = dgvNguyenLieu.Rows[numrow].Cells[6].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Them";
            textTenNL.Clear();
            textSoLuong.Clear();
            textNguoiNhap.Clear();
            textDonViTinh.Clear();
            textDonGia.Clear();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Sua";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                myDataBases db = new myDataBases();
                db.executeQuery("delete from tblNguyenLieu where MaNL='" + MaNL + "'");
                refreshDataGridView();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                if (kt == "Them")
                {
                    db.executeQuery("insert into tblNguyenLieu values (dbo.sinhmaNL(),N'" + textTenNL.Text + "','" + cbMaNCC.Text + "'," + textSoLuong.Text + ",'" + formLogin.MaNguoiDung + "',N'" + textDonViTinh.Text + "'," + textDonGia.Text + ")");
                    MessageBox.Show("Thêm nguyên liệu thành công!");
                }
                if (kt == "Sua")
                {
                    db.executeQuery("update tblNguyenLieu set TenNL = N'" + textTenNL.Text + "' where MaNL='" + MaNL + "'");
                    db.executeQuery("update tblNguyenLieu set MaNCC = '" + cbMaNCC.Text + "' where MaNL='" + MaNL + "'");
                    db.executeQuery("update tblNguyenLieu set MaNVNhap = '" + formLogin.MaNguoiDung + "' where MaNL='" + MaNL + "'");
                    db.executeQuery("update tblNguyenLieu set SoLuong = " + textSoLuong.Text + " where MaNL='" + MaNL + "'");
                    db.executeQuery("update tblNguyenLieu set DonViTinh = N'" + textDonViTinh.Text + "' where MaNL='" + MaNL + "'");
                    db.executeQuery("update tblNguyenLieu set DonGia = " + textDonGia.Text + " where MaNL='" + MaNL + "'");
                    MessageBox.Show("Sửa nguyên liệu thành công!");
                }
                setControls(true);
                refreshDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thành công!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            setControls(true);
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            dgvNguyenLieu.DataSource = db.getData("select * from tblNguyenLieu where TenNL like N'%"+textTim_TenNL.Text+"%'");
        }

        private void BtnDanhSach_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}