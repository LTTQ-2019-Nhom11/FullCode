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
    public partial class ViewHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public ViewHoaDon()
        {
            InitializeComponent();
        }

      

        private void ViewHoaDon_Load(object sender, EventArgs e)
        {
            if ((formLogin.quyen == "Giám Đốc") || (formLogin.quyen == "Bồi Bàn"))
            {
                btnThanhToan.Visible = true;
            }
            lblTime.Text = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lblDate.Text = (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "-" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + DateTime.Now.Year;
            lbhoten.Text = formLogin.hoten;
            lbBanSo.Text = formGoiMon.SoBan;
            lbSoKhach.Text = formGoiMon.SoKhach;
            lbTongTien.Text = formGoiMon.TongTien + "VNĐ";
            try
            {
                myDataBases db = new myDataBases();
                dgvMonAn.DataSource = db.getData("select TenThucDon, DonGia, SoLuong from tblGoiMon1 join tblThucDon on tblGoiMon1.MaThucDon=tblThucDon.MaThucDon where MaBanAn=" + lbBanSo.Text + " and XacNhan!=N'Hủy'");
                for (int i = 0; i < dgvMonAn.Rows.Count -1; i++)
                    dgvMonAn.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn bàn!");
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                myDataBases db = new myDataBases();
                string date = DateTime.Now.Year + "-" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "-" + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());

                db.executeQuery("insert into tblHoaDon values (dbo.sinhmaHD()," + lbBanSo.Text + ",'" + date + " " + lblTime.Text + "'," + lbSoKhach.Text + ",'" + formLogin.MaNguoiDung + "'," + formGoiMon.TongTien + ")");
                
                DataTable dt = db.getData("select tblGoiMon1.MaThucDon, SoLuong from tblGoiMon1 join tblThucDon on tblGoiMon1.MaThucDon=tblThucDon.MaThucDon where MaBanAn=" + lbBanSo.Text + " and XacNhan!=N'Hủy'");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        db.executeQuery("insert into tblCTHD values (dbo.sinhmaCTHD(),'" + dr["MaThucDon"].ToString() + "'," + dr["SoLuong"].ToString() + ")");
                    }
                }
                db.executeQuery("delete from tblGoiMon1 where MaBanAn=" + lbBanSo.Text);
                MessageBox.Show("Đã lưu!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
            }
        }
    }
}