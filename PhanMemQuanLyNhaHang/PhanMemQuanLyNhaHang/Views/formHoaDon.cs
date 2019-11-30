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
    public partial class formHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtExcel = new DataTable();
        private string ngaylp = "", nguoilp = "", banso = "", sokhach = "", tongtien = "";
        public formHoaDon()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvHoaDon.DataSource = db.getData("SELECT * FROM tblHoaDon");
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
            for(int i=0; i<9; i++)
            {
                cbThang.Items.Add("0"+(i+1).ToString());
            }
            for (int i = 9; i < 12; i++)
            {
                cbThang.Items.Add((i + 1).ToString());
            }
            myDataBases db = new myDataBases();
            DataTable dt = db.getData("select TenThucDon, SUM(SoLuong) from tblThucDon join tblCTHD on tblThucDon.MaThucDon = tblCTHD.MaThucDon group by tblCTHD.MaThucDon, TenThucDon having SUM(SoLuong) >=all (select SUM(SoLuong) from tblCTHD group by MaThucDon)");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbMaxTD.Text = dr["TenThucDon"].ToString();
                }
            }
            DataTable dt1 = db.getData("select SUM(TongTien) as TongTien, SUM(SoKhach) as TongKhach from tblHoaDon");
            if (dt1 != null)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    lbTongKhach.Text = dr["TongKhach"].ToString() +" khách";
                    lbTongTien.Text = dr["TongTien"].ToString() + " VNĐ";
                }
            }
        }

        private void DgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                myDataBases db = new myDataBases();
                dgvCTHD.DataSource = db.getData("select tblCTHD.*, TenThucDon, DonGia from tblCTHD join tblThucDon on tblCTHD.MaThucDon=tblThucDon.MaThucDon where SoHD='" + dgvHoaDon.Rows[numrow].Cells[0].Value.ToString() + "'");
                dtExcel = db.getData("select tblCTHD.*, TenThucDon, DonGia from tblCTHD join tblThucDon on tblCTHD.MaThucDon=tblThucDon.MaThucDon where SoHD='" + dgvHoaDon.Rows[numrow].Cells[0].Value.ToString() + "'");            
                ngaylp = dgvHoaDon.Rows[numrow].Cells[2].Value.ToString();
                nguoilp = dgvHoaDon.Rows[numrow].Cells[4].Value.ToString();
                banso = dgvHoaDon.Rows[numrow].Cells[1].Value.ToString(); ;
                sokhach = dgvHoaDon.Rows[numrow].Cells[3].Value.ToString();
                tongtien = dgvHoaDon.Rows[numrow].Cells[5].Value.ToString();
            }
        }

        private void BtnTheoNgay_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            DateTime dateTime = dateNgay.DateTime;
            dgvHoaDon.DataSource = db.getData("select * from tblHoaDon where CONVERT(nvarchar(10), ThoiGianLap, 121)='" + dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + "'");
            DataTable dt = db.getData("select TenThucDon, SUM(SoLuong) from tblThucDon join tblCTHD on tblThucDon.MaThucDon = tblCTHD.MaThucDon join tblHoaDon on tblHoaDon.SoHD = tblCTHD.SoHD where CONVERT(nvarchar(10), ThoiGianLap, 121)='" + dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + "' group by tblCTHD.MaThucDon, TenThucDon having SUM(SoLuong) >=all (select SUM(SoLuong) from tblCTHD join tblHoaDon on tblHoaDon.SoHD = tblCTHD.SoHD where CONVERT(nvarchar(10), ThoiGianLap, 121)='" + dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + "' group by MaThucDon)");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbMaxTD.Text = dr["TenThucDon"].ToString();
                }
            }
            DataTable dt1 = db.getData("select SUM(TongTien) as TongTien, SUM(SoKhach) as TongKhach from tblHoaDon where CONVERT(nvarchar(10), ThoiGianLap, 121)='" + dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString() + "'");
            if (dt1 != null)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    lbTongKhach.Text = dr["TongKhach"].ToString() + "khách";
                    lbTongTien.Text = dr["TongTien"].ToString() + " VNĐ";
                }
            }
        }

        private void BtnTheoThang_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            dgvHoaDon.DataSource = db.getData("select * from tblHoaDon where CONVERT(nvarchar(7), ThoiGianLap, 121)='" + textNam.Text + "-" + cbThang.Text + "'");
            DataTable dt = db.getData("select TenThucDon, SUM(SoLuong) from tblThucDon join tblCTHD on tblThucDon.MaThucDon = tblCTHD.MaThucDon join tblHoaDon on tblHoaDon.SoHD = tblCTHD.SoHD where CONVERT(nvarchar(7), ThoiGianLap, 121)='" + textNam.Text + "-" + cbThang.Text + "' group by tblCTHD.MaThucDon, TenThucDon having SUM(SoLuong) >=all (select SUM(SoLuong) from tblCTHD join tblHoaDon on tblHoaDon.SoHD = tblCTHD.SoHD where CONVERT(nvarchar(7), ThoiGianLap, 121)='" + textNam.Text + "-" + cbThang.Text + "' group by MaThucDon)");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbMaxTD.Text = dr["TenThucDon"].ToString();
                }
            }
            DataTable dt1 = db.getData("select SUM(TongTien) as TongTien, SUM(SoKhach) as TongKhach from tblHoaDon where CONVERT(nvarchar(7), ThoiGianLap, 121)='" + textNam.Text + "-" + cbThang.Text + "'");
            if (dt1 != null)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    lbTongKhach.Text = dr["TongKhach"].ToString() + " khách";
                    lbTongTien.Text = dr["TongTien"].ToString() + " VNĐ";
                }
            }
        }

        private void BtnTheoKhoang_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            DateTime dateTime1 = dateTu.DateTime, dateTime2 = dateDen.DateTime;
            dgvHoaDon.DataSource = db.getData("select * from tblHoaDon where ThoiGianLap >='" + dateTime1.Year.ToString() + "-" + dateTime1.Month.ToString() + "-" + dateTime1.Day.ToString() + " 00:00:00' and ThoiGianLap <='" + dateTime2.Year.ToString() + "-" + dateTime2.Month.ToString() + "-" + dateTime2.Day.ToString() + " 23:59:59'");
            DataTable dt = db.getData("select TenThucDon, SUM(SoLuong) from tblThucDon join tblCTHD on tblThucDon.MaThucDon = tblCTHD.MaThucDon join tblHoaDon on tblHoaDon.SoHD = tblCTHD.SoHD where ThoiGianLap >='" + dateTime1.Year.ToString() + "-" + dateTime1.Month.ToString() + "-" + dateTime1.Day.ToString() + " 00:00:00' and ThoiGianLap <='" + dateTime2.Year.ToString() + "-" + dateTime2.Month.ToString() + "-" + dateTime2.Day.ToString() + " 23:59:59' group by tblCTHD.MaThucDon, TenThucDon having SUM(SoLuong) >=all (select SUM(SoLuong) from tblCTHD join tblHoaDon on tblHoaDon.SoHD = tblCTHD.SoHD where ThoiGianLap >='" + dateTime1.Year.ToString() + "-" + dateTime1.Month.ToString() + "-" + dateTime1.Day.ToString() + " 00:00:00' and ThoiGianLap <='" + dateTime2.Year.ToString() + "-" + dateTime2.Month.ToString() + "-" + dateTime2.Day.ToString() + " 23:59:59' group by MaThucDon)");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbMaxTD.Text = dr["TenThucDon"].ToString();
                }
            }
            DataTable dt1 = db.getData("select SUM(TongTien) as TongTien, SUM(SoKhach) as TongKhach from tblHoaDon where ThoiGianLap >='" + dateTime1.Year.ToString() + "-" + dateTime1.Month.ToString() + "-" + dateTime1.Day.ToString() + " 00:00:00' and ThoiGianLap <='" + dateTime2.Year.ToString() + "-" + dateTime2.Month.ToString() + "-" + dateTime2.Day.ToString() + " 23:59:59'");
            if (dt1 != null)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    lbTongKhach.Text = dr["TongKhach"].ToString() + " khách";
                    lbTongTien.Text = dr["TongTien"].ToString() + " VNĐ";
                }
            }
        }

        private void BtnDanhSach_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
            myDataBases db = new myDataBases();
            DataTable dt = db.getData("select TenThucDon, SUM(SoLuong) from tblThucDon join tblCTHD on tblThucDon.MaThucDon = tblCTHD.MaThucDon group by tblCTHD.MaThucDon, TenThucDon having SUM(SoLuong) >=all (select SUM(SoLuong) from tblCTHD group by MaThucDon)");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbMaxTD.Text = dr["TenThucDon"].ToString();
                }
            }
            DataTable dt1 = db.getData("select SUM(TongTien) as TongTien, SUM(SoKhach) as TongKhach from tblHoaDon");
            if (dt1 != null)
            {
                foreach (DataRow dr in dt1.Rows)
                {
                    lbTongKhach.Text = dr["TongKhach"].ToString() + " khách";
                    lbTongTien.Text = dr["TongTien"].ToString() + " VNĐ";
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Excel.Application exApp;
            Excel.Workbook exBook;
            Excel.Worksheet exSheet;
            Excel.Range exRange;
            exApp = new Excel.Application();
            exBook = (Excel.Workbook)(exApp.Workbooks.Add(true));
            exSheet = (Excel.Worksheet)exBook.ActiveSheet;

            Excel.Range head = exSheet.get_Range("B2", "D2");
            head.MergeCells = true;
            head.Value2 = "HÓA ĐƠN TÍNH TIỀN";
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "18";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            Excel.Range cl1 = exSheet.get_Range("B10", "B10");
            cl1.Value2 = "Tên Món";
            cl1.ColumnWidth = 30;

            Excel.Range cl2 = exSheet.get_Range("C10", "C10");
            cl2.Value2 = "Đơn Giá";
            cl2.ColumnWidth = 20;
            cl2.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range cl3 = exSheet.get_Range("D10", "D10");
            cl3.Value2 = "Số Lượng";
            cl3.ColumnWidth = 10;
            cl3.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

            Excel.Range cl4 = exSheet.get_Range("C4", "C8");
            cl4.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            exSheet.Cells[4, 2] = "Ngày Lập Phiếu: ";
            exSheet.Cells[4, 3] = ngaylp;
            exSheet.Cells[5, 2] = "Người Lập Phiếu: ";
            myDataBases db = new myDataBases();
            DataTable dtHoTen = db.getData("select HoTen from tblNguoiDung where MaNguoiDung='" + nguoilp + "'");
            string tenlp = "";
            if (dtHoTen != null)
            {
                foreach (DataRow dr in dtHoTen.Rows)
                {
                    tenlp = dr["HoTen"].ToString();
                }
            }
            exSheet.Cells[5, 3] = tenlp;
            exSheet.Cells[6, 2] = "Bàn Số: ";
            exSheet.Cells[6, 3] = banso;
            exSheet.Cells[7, 2] = "Số Khách: ";
            exSheet.Cells[7, 3] = sokhach;
            exSheet.Cells[8, 2] = "Tổng Tiền: ";
            exSheet.Cells[8, 3] = tongtien + " VNĐ";
            int iRow = 11;
            for (int i = 0; i < dtExcel.Rows.Count; i++)
            {

                exSheet.Cells[iRow, 2] = dtExcel.Rows[i]["TenThucDon"].ToString();
                exSheet.Cells[iRow, 3] = dtExcel.Rows[i]["DonGia"].ToString();
                exSheet.Cells[iRow, 4] = dtExcel.Rows[i]["SoLuong"].ToString();
                iRow++;
            }
            exRange = exSheet.get_Range("B10", "D" + (iRow - 1).ToString());
            
            exRange.Borders.Color = Color.Black.ToArgb();

            //exSheet.Cells[iRow+1, 3] = "Nhà Hàng MyLove";
            Excel.Range nhahang = exSheet.get_Range("C" + (iRow + 1).ToString(), "D" + (iRow + 1).ToString());
            nhahang.MergeCells = true;
            nhahang.Font.Name = "Times New Roman";
            nhahang.Value2 = "Nhà Hàng MyLove";
            nhahang.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            exApp.UserControl = false;
            exApp.Visible = true;
        }
    }
}