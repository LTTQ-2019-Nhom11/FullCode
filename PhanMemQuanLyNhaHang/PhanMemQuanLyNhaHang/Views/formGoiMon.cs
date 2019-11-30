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
    public partial class formGoiMon : DevExpress.XtraEditors.XtraForm
    {
        private int dgvrow, lvrow, n = 0;
        public static string SoBan = "", SoKhach = "", TongTien = "";
        public formGoiMon()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvThucDon.DataSource = db.getData("SELECT * FROM tblThucDon");
        }
        private void DataGridView_DuaMon()
        {
            myDataBases db = new myDataBases();
            dgvDuaMon.DataSource = db.getData("select distinct MaBanAn from tblGoiMon1 where XacNhan = N'Xong'");
            dgvHuyMon.DataSource = db.getData("select distinct MaBanAn, TenThucDon from tblGoiMon1 join tblThucDon on tblGoiMon1.MaThucDon=tblThucDon.MaThucDon where XacNhan = N'Hủy'");
        }
        private void FormGoiMon_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            myDataBases db = new myDataBases();
            DataTable dt = db.getData("SELECT * FROM tblBanAn");
            foreach (DataRow dr in dt.Rows)
            {
                cbChonBan.Items.Add(dr["MaBanAn"].ToString());
            }
            cbLoaiThucDon.Items.Add("==Tất Cả==");
            DataTable dt1 = db.getData("select distinct Loai from tblThucDon");
            foreach (DataRow dr in dt1.Rows)
            {
                cbLoaiThucDon.Items.Add(dr["Loai"].ToString());
            }
            DataGridView_DuaMon();
        }

        private void DgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvrow = e.RowIndex;
            DataGridView_DuaMon();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (dgvrow >= 0)
            {
                lvThucDon.Items.Add(dgvThucDon.Rows[dgvrow].Cells[2].Value.ToString());
                lvThucDon.Items[n].SubItems.Add(dgvThucDon.Rows[dgvrow].Cells[4].Value.ToString());
                lvThucDon.Items[n].SubItems.Add(nudSoLuong.Value.ToString());
                lvThucDon.Items[n].SubItems.Add("Chưa Xong");
                lvThucDon.Items[n].SubItems.Add(dgvThucDon.Rows[dgvrow].Cells[0].Value.ToString());
                n++;
            }
            DataGridView_DuaMon();
        }

        private void BtnGoiMon_Click(object sender, EventArgs e)
        {
           
            try
            {
                myDataBases db = new myDataBases();
                for (int i = 0; i < n; i++)
                {
                    db.executeQuery("insert into tblGoiMon1 values (" + cbChonBan.Text + ",'" + lvThucDon.Items[i].SubItems[4].Text + "'," + lvThucDon.Items[i].SubItems[2].Text + ",N'Chưa Xong')");
                }
                MessageBox.Show("Gọi món thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn bàn!");
            }
            DataGridView_DuaMon();
        }

        private void CbChonBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvThucDon.Clear();
            lvThucDon.Columns.Add("Thực Đơn", 175);
            lvThucDon.Columns.Add("Đơn Giá", 120);
            lvThucDon.Columns.Add("Số Lượng", 90);
            lvThucDon.Columns.Add("Xác Nhận", 100);
            myDataBases db = new myDataBases();
            DataTable dt = db.getData("select TenThucDon, DonGia, SoLuong, XacNhan from tblGoiMon1 join tblThucDon on tblGoiMon1.MaThucDon=tblThucDon.MaThucDon where MaBanAn="+cbChonBan.Text);
            n = dt.Rows.Count;
            int dem = 0;
            double tongtien = 0;
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lvThucDon.Items.Add(dr["TenThucDon"].ToString());
                    lvThucDon.Items[dem].SubItems.Add(dr["DonGia"].ToString());
                    lvThucDon.Items[dem].SubItems.Add(dr["SoLuong"].ToString());
                    lvThucDon.Items[dem].SubItems.Add(dr["XacNhan"].ToString());
                    if(dr["XacNhan"].ToString() != "Hủy")
                        tongtien += double.Parse(dr["DonGia"].ToString()) * double.Parse(dr["SoLuong"].ToString());
                    dem++;
                }
            }
            lbTongTien.Text = tongtien.ToString();
            DataGridView_DuaMon();
        }

        private void CbLoaiThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            if(cbLoaiThucDon.Text == "==Tất Cả==")
                dgvThucDon.DataSource = db.getData("SELECT * FROM tblThucDon");
            else
                dgvThucDon.DataSource = db.getData("SELECT * FROM tblThucDon where Loai=N'" + cbLoaiThucDon.Text + "'");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lblDate.Text = (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            SoBan = cbChonBan.Text;
            SoKhach = nudSoKhach.Value.ToString();
            TongTien = lbTongTien.Text;
            ViewHoaDon viewHoaDon = new ViewHoaDon();
            viewHoaDon.ShowDialog();
            
        }

        private void BtnXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvrow < 0)
                    MessageBox.Show("Bấm vào tên thực đơn đã gọi để xóa!");
                else
                {
                    lvThucDon.Items.RemoveAt(lvrow);
                    n--;
                    lvrow = -1;
                }
            }
            catch (Exception)
            {
            }
            DataGridView_DuaMon();
        }

        private void LvThucDon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lvrow = e.ItemIndex;
            DataGridView_DuaMon();
        }
    }
}