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
    public partial class formXacNhanNhapNL : DevExpress.XtraEditors.XtraForm
    {
        private int dgvrow;
        private string MaNL = "";
        public formXacNhanNhapNL()
        {
            InitializeComponent();
        }
        private void refreshDataGridView()
        {
            myDataBases db = new myDataBases();
            dgvYeuCauMua.DataSource = db.getData("select tblYC_MuaNL.MaNL, TenNL, SUM(tblYC_MuaNL.SoLuong) as SoLuong, DonGia, DonViTinh, XacNhan from tblYC_MuaNL join tblNguyenLieu on tblYC_MuaNL.MaNL  = tblNguyenLieu.MaNL group by tblYC_MuaNL.MaNL, tblYC_MuaNL.MaNL, TenNL, DonGia, DonViTinh, XacNhan");
        }

        private void FormXacNhanNhapNL_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            db.executeQuery("update tblYC_MuaNL set XacNhan=N'Chấp Nhận' where MaNL='" + MaNL + "'");
            refreshDataGridView();
        }

        private void DgvYeuCauMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvrow = e.RowIndex;
            if (dgvrow >= 0)
            {
                //textTenNL.Text = dgvYeuCauNL.Rows[dgvrowNL].Cells[1].Value.ToString();
                //textSoLuong.Text = dgvYeuCauNL.Rows[dgvrowNL].Cells[2].Value.ToString();
                MaNL = dgvYeuCauMua.Rows[dgvrow].Cells[0].Value.ToString();
            }
        }

        private void BtnTuChoi_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            db.executeQuery("delete from tblYC_MuaNL where MaNL='" + MaNL + "'");
            refreshDataGridView();
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            myDataBases db = new myDataBases();
            db.executeQuery("update tblYC_MuaNL set XacNhan=N'Chấp Nhận'");
            refreshDataGridView();
        }
    }
}