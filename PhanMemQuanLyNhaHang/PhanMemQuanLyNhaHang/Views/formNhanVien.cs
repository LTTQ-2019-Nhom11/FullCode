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
    public partial class formNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public string kt = "";
        public string MaND = "";
        public formNhanVien()
        {
            InitializeComponent();
        }
        private void setControls(bool s)
        {
            btnThem.Enabled = s;
            btnSua.Enabled = s;
            btnXoa.Enabled = s;
            btnSave.Enabled = !s;
            btnCancel.Enabled = !s;

            textHoTen.Enabled = !s;
            dateNgaySinh.Enabled = !s;
            textGioiTinh.Visible = s;
            rbNam.Visible = !s;
            rbNu.Visible = !s;
            textQueQuan.Enabled = !s;
            textSDT.Enabled = !s;
            textTenDangNhap.Enabled = !s;
            textMatKhau.Enabled = !s;
            cbQuyen.Enabled = !s;
            
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvNhanVien.DataSource = db.getData("SELECT * FROM tblNguoiDung");
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            if (formLogin.quyen.ToString() == "Giám Đốc")
            {
                btnSave.Visible = true;
                btnCancel.Visible = true;
                grXuLy.Visible = true;
                lbTenDangNhap.Visible = true;
                lbMatKhau.Visible = true;
                lbQuyen.Visible = true;
                textTenDangNhap.Visible = true;
                textMatKhau.Visible = true;
                cbQuyen.Visible = true;
                myDataBases db = new myDataBases();
                DataTable dt = db.getData("select distinct Quyen from tblNguoiDung");
                foreach (DataRow dr in dt.Rows)
                {
                    cbQuyen.Items.Add(dr["Quyen"].ToString());
                }
            }
        }

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                textHoTen.Text = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
                dateNgaySinh.Text = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
                textGioiTinh.Text = dgvNhanVien.Rows[numrow].Cells[3].Value.ToString();
                textQueQuan.Text = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
                textSDT.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();
                textTenDangNhap.Text = dgvNhanVien.Rows[numrow].Cells[6].Value.ToString();
                textMatKhau.Text = dgvNhanVien.Rows[numrow].Cells[7].Value.ToString();
                cbQuyen.Text = dgvNhanVien.Rows[numrow].Cells[8].Value.ToString();
                MaND = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Them";
            textHoTen.Clear();
            textGioiTinh.Clear();
            textQueQuan.Clear();
            textSDT.Clear();
            textTenDangNhap.Clear();
            textMatKhau.Clear();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Sua";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa nhân viên không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                myDataBases db = new myDataBases();
                db.executeQuery("delete from tblNguoiDung where MaNguoiDung='" + MaND+ "'");
                refreshDataGridView();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            setControls(true);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                if (kt == "Them")
                {
                    if (rbNam.Checked == true)
                        db.executeQuery("insert into tblNguoiDung values (dbo.sinhmaND(),N'" + textHoTen.Text + "','" + dateNgaySinh.Text + "',N'Nam',N'" + textQueQuan.Text + "','" + textSDT.Text + "','" + textTenDangNhap.Text + "','" + textMatKhau.Text + "',N'" + cbQuyen.Text + "')");
                    if (rbNu.Checked == true)
                        db.executeQuery("insert into tblNguoiDung values (dbo.sinhmaND(),N'" + textHoTen.Text + "','" + dateNgaySinh.Text + "',N'Nữ',N'" + textQueQuan.Text + "','" + textSDT.Text + "','" + textTenDangNhap.Text + "','" + textMatKhau.Text + "',N'" + cbQuyen.Text + "')");
                    if ((rbNam.Checked == false) && (rbNu.Checked == false))
                        db.executeQuery("insert into tblNguoiDung values (dbo.sinhmaND(),N'" + textHoTen.Text + "','" + dateNgaySinh.Text + "',N'',N'" + textQueQuan.Text + "','" + textSDT.Text + "','" + textTenDangNhap.Text + "','" + textMatKhau.Text + "',N'" + cbQuyen.Text + "')");
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                if (kt == "Sua")
                {
                    db.executeQuery("update tblNguoiDung set HoTen = N'" + textHoTen.Text + "' where MaNguoiDung='" + MaND + "'");
                    db.executeQuery("update tblNguoiDung set NgaySinh = N'" + dateNgaySinh.Text + "' where MaNguoiDung='" + MaND + "'");
                    if (rbNam.Checked == true)
                        db.executeQuery("update tblNguoiDung set GioiTinh = N'Nam' where MaNguoiDung='" + MaND + "'");
                    if (rbNu.Checked == true)
                        db.executeQuery("update tblNguoiDung set GioiTinh = N'Nữ' where MaNguoiDung='" + MaND + "'");
                    if ((rbNam.Checked == false) && (rbNu.Checked == false))
                        db.executeQuery("update tblNguoiDung set GioiTinh = N'' where MaNguoiDung='" + MaND + "'");
                    db.executeQuery("update tblNguoiDung set QueQuan = N'" + textQueQuan.Text + "' where MaNguoiDung='" + MaND + "'");
                    db.executeQuery("update tblNguoiDung set SDT = N'" + textSDT.Text + "' where MaNguoiDung='" + MaND + "'");
                    db.executeQuery("update tblNguoiDung set TenDangNhap = N'" + textTenDangNhap.Text + "' where MaNguoiDung='" + MaND + "'");
                    db.executeQuery("update tblNguoiDung set MatKhau = N'" + textMatKhau.Text + "' where MaNguoiDung='" + MaND + "'");
                    db.executeQuery("update tblNguoiDung set Quyen = N'" + cbQuyen.Text + "' where MaNguoiDung='" + MaND + "'");
                    MessageBox.Show("Sửa nhân viên thành công!");
                }
                setControls(true);
                refreshDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thành công!");
            }
            
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            dgvNhanVien.DataSource = db.getData("select * from tblNguoiDung where HoTen like N'%" + textTim_HoTen.Text + "%'");
        }

        private void BtnDanhSach_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}