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
    public partial class formNCC : DevExpress.XtraEditors.XtraForm
    {
        public string kt = "";
        public string MaNCC1 = "";
        public formNCC()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvNCC.DataSource = db.getData("SELECT * FROM tblNCC");

        }
        private void setControls(bool s)
        {
            btnThem.Enabled = s;
            btnSua.Enabled = s;
            btnXoa.Enabled = s;
            btnSave.Enabled = !s;
            btnCancel.Enabled = !s;

            textTenNCC.Enabled = !s;
            textDiaChi.Enabled = !s;
            textSDT.Enabled = !s;
            textEmail.Enabled = !s;
        }
        private void DgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                textTenNCC.Text = dgvNCC.Rows[numrow].Cells[1].Value.ToString();
                textDiaChi.Text = dgvNCC.Rows[numrow].Cells[2].Value.ToString();
                textSDT.Text = dgvNCC.Rows[numrow].Cells[3].Value.ToString();
                textEmail.Text = dgvNCC.Rows[numrow].Cells[4].Value.ToString();
                MaNCC1 = dgvNCC.Rows[numrow].Cells[0].Value.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Them";
            textTenNCC.Clear();
            textDiaChi.Clear();
            textSDT.Clear();
            textEmail.Clear();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Sua";
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                myDataBases db = new myDataBases();
                db.executeQuery("delete from tblNCC where MaNCC='" + MaNCC1 + "'");
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
                    db.executeQuery("insert into tblNCC values (dbo.sinhmaNCC(),N'"+textTenNCC.Text+"',N'"+textDiaChi.Text+"','"+textSDT.Text+"',N'"+textEmail.Text+"')");
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                }
                if (kt == "Sua")
                {
                    db.executeQuery("update tblNCC set TenNCC=N'" + textTenNCC.Text + "' where MaNCC='" + MaNCC1 + "'");
                    db.executeQuery("update tblNCC set DiaChi=N'" + textDiaChi.Text + "' where MaNCC='" + MaNCC1 + "'");
                    db.executeQuery("update tblNCC set SDT='" + textSDT.Text + "' where MaNCC='" + MaNCC1 + "'");
                    db.executeQuery("update tblNCC set Email=N'" + textEmail.Text + "' where MaNCC='" + MaNCC1 + "'");
                    MessageBox.Show("Sửa nhà cung cấp thành công!");
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

        private void FormNCC_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            if (formLogin.quyen.ToString() == "Giám Đốc")
            {
                btnSave.Visible = true;
                btnCancel.Visible = true;
                grXuLy.Visible = true;
            }
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            dgvNCC.DataSource = db.getData("select * from tblNCC where TenNCC like N'%" + textTim_TenNCC.Text + "%'");
        }

        private void BtnDanhSach_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}