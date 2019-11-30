using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhanMemQuanLyNhaHang.Views;

namespace PhanMemQuanLyNhaHang
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       public formMain()
        {
            InitializeComponent();
        }
        public void skins()
        {
            
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            skins();
            string hoten = formLogin.hoten;
            string quyen = formLogin.quyen;
            txtTen.Caption = hoten + "!";
            if(quyen != "guest")
            {
                btnNhanVien.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            if(quyen == "Giám Đốc")
            {
                rbpPhucVu.Visible = true;
                rbpQuanLy.Visible = true;
                rbpNhaBep.Visible = true;
                rbpKho.Visible = true;
                rbpThuNgan.Visible = true;
                rbpXem.Visible = false;
            }
            if(quyen == "Bồi Bàn")
            {
                rbpPhucVu.Visible = true;
            }
            if(quyen == "Thu Ngân")
            {
                rbpThuNgan.Visible = true;
            }
            if(quyen == "Đầu Bếp")
            {
                rbpNhaBep.Visible = true;
            }
            if(quyen == "Thủ Kho")
            {
                rbpKho.Visible = true;
            }
        }

        private void BtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formLogin flogin = new formLogin();
            flogin.ShowDialog();
        }

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formGoiMon formGoiMon = new formGoiMon();
            formGoiMon.ShowDialog();
        }

        private void BtnTimThucDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formThucDon formThucDon = new formThucDon();
            formThucDon.ShowDialog();
        }

        private void BtnTimNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNhanVien formNhanVien = new formNhanVien();
            formNhanVien.ShowDialog();
        }

        private void BtnQLTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formThucDon formThucDon = new formThucDon();
            formThucDon.ShowDialog();
        }

        private void BtnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNhanVien formNhanVien = new formNhanVien();
            formNhanVien.ShowDialog();
        }

        private void BtnQLHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formHoaDon formHoaDon = new formHoaDon();
            formHoaDon.ShowDialog();
        }


        private void BtnThucDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formThucDon formThucDon = new formThucDon();
            formThucDon.ShowDialog();
        }

        private void BtnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNhanVien formNhanVien = new formNhanVien();
            formNhanVien.ShowDialog();
        }

        private void BtnThucDon1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formThucDon formThucDon = new formThucDon();
            formThucDon.ShowDialog();
        }

        private void BtnNhanVien1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNhanVien formNhanVien = new formNhanVien();
            formNhanVien.ShowDialog();
        }

        private void BtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (h == DialogResult.OK)
            {
                //Application.Exit();
                this.Hide();
                formLogin formLogin = new formLogin();
                formLogin.ShowDialog();
            }
        }

        private void BtnCheBien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formCheBien formCheBien = new formCheBien();
            formCheBien.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Caption = (DateTime.Now.Hour < 10 ? "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString()) + ":" + (DateTime.Now.Minute < 10 ? "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString()) + ":" + (DateTime.Now.Second < 10 ? "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());
            lblDate.Caption = DateTime.Now.DayOfWeek.ToString() + ", " + (DateTime.Now.Day < 10 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) + "/" + (DateTime.Now.Month < 10 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + "/" + DateTime.Now.Year;
        }

        private void BtnNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNguyenLieu formNguyenLieu = new formNguyenLieu();
            formNguyenLieu.ShowDialog();
        }

        private void BtnNCC1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNCC formNCC = new formNCC();
            formNCC.ShowDialog();
        }

        private void BtnNguyenLieu1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formNguyenLieu formNguyenLieu = new formNguyenLieu();
            formNguyenLieu.ShowDialog();
        }

        private void BtnHoaDon1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formHoaDon formHoaDon = new formHoaDon();
            formHoaDon.ShowDialog();
        }

        private void BtnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formHoaDon formHoaDon = new formHoaDon();
            formHoaDon.ShowDialog();
        }

        private void BtnNLYeuCau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formXuatNL formXuatNL = new formXuatNL();
            formXuatNL.ShowDialog();
        }

        private void BtnXacNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formXacNhanNhapNL formXacNhanNhapNL = new formXacNhanNhapNL();
            formXacNhanNhapNL.ShowDialog();
        }

        private void BtnThanhToanNL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formThanhToanNL formThanhToanNL = new formThanhToanNL();
            formThanhToanNL.ShowDialog();
        }
    }
}
