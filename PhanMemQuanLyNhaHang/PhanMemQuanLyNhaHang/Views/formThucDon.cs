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
    public partial class formThucDon : DevExpress.XtraEditors.XtraForm
    {
        public string kt = "";
        public string MaTD = "";
        public formThucDon()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvThucDon.DataSource = db.getData("SELECT * FROM tblThucDon");
            
        }
        private void setControls(bool s)
        {
            btnThem.Enabled = s;
            btnSua.Enabled = s;
            btnXoa.Enabled = s;
            btnSave.Enabled = !s;
            btnCancel.Enabled = !s;

            cbLoaiThucDon.Enabled = !s;
            textTenThucDon.Enabled = !s;
            textDonViTinh.Enabled = !s;
            textDonGia.Enabled = !s;
        }


        private void FormThucDon_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            if(formLogin.quyen.ToString() == "Giám Đốc")
            {
                btnSave.Visible = true;
                btnCancel.Visible = true;
                grXuLy.Visible = true;
            }
            myDataBases db = new myDataBases();
            DataTable dt1 = db.getData("select distinct Loai from tblThucDon");
            cbTim_LoaiThucDon.Items.Add("==Tất Cả==");
            foreach (DataRow dr in dt1.Rows)
            {
                cbLoaiThucDon.Items.Add(dr["Loai"].ToString());
                cbTim_LoaiThucDon.Items.Add(dr["Loai"].ToString());
            }
        }

        private void DgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                cbLoaiThucDon.Text = dgvThucDon.Rows[numrow].Cells[1].Value.ToString();
                textTenThucDon.Text = dgvThucDon.Rows[numrow].Cells[2].Value.ToString();
                textDonViTinh.Text = dgvThucDon.Rows[numrow].Cells[3].Value.ToString();
                textDonGia.Text = dgvThucDon.Rows[numrow].Cells[4].Value.ToString();
                MaTD = dgvThucDon.Rows[numrow].Cells[0].Value.ToString();
            }
            
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                if (kt == "Them")
                {
                    db.executeQuery("INSERT INTO tblThucDon values(dbo.sinhmaTD(), N'" + cbLoaiThucDon.Text + "', N'" + textTenThucDon.Text + "', N'" + textDonViTinh.Text + "'," + textDonGia.Text + ")");
                    MessageBox.Show("Thêm thực đơn thành công!");
                }
                if (kt == "Sua")
                {
                    db.executeQuery("update tblThucDon set Loai =N'" + cbLoaiThucDon.Text + "' where MaThucDon = '" + MaTD + "'");
                    db.executeQuery("update tblThucDon set TenThucDon =N'" + textTenThucDon.Text + "' where MaThucDon = '" + MaTD + "'");
                    db.executeQuery("update tblThucDon set DonViTinh =N'" + textDonViTinh.Text + "' where MaThucDon = '" + MaTD + "'");
                    db.executeQuery("update tblThucDon set DonGia =" + textDonGia.Text + "where MaThucDon = '" + MaTD + "'");
                    MessageBox.Show("Sửa thực đơn thành công!");
                }
                setControls(true);
                refreshDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi! Không thành công!");
            }
           
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            setControls(false);
            kt = "Them";
            textTenThucDon.Clear();
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
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa thực đơn không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                myDataBases db = new myDataBases();
                db.executeQuery("delete from tblThucDon where MaThucDon='" + MaTD + "'");
                refreshDataGridView();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            setControls(true);
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            if (cbTim_LoaiThucDon.Text == "==Tất Cả==")
                dgvThucDon.DataSource = db.getData("select * from tblThucDon where TenThucDon like N'%" + textTim_TenThucDon.Text + "%'");
            else
                dgvThucDon.DataSource = db.getData("select * from tblThucDon where TenThucDon like N'%" + textTim_TenThucDon.Text + "%' and Loai=N'" + cbTim_LoaiThucDon.Text + "'");
        }

        private void BtnDanhSach_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }
    }
}