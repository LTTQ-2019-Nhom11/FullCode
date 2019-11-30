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
using System.Data;
using System.Data.SqlClient;

namespace PhanMemQuanLyNhaHang.Views
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        public formLogin()
        {
            InitializeComponent();
        }
        public static string MaNguoiDung = "", quyen = "", hoten = "";
        private string getID(string tendangnhap, string matkhau)
        {
            string id = "";
            try
            {
                myDataBases db = new myDataBases();
                DataTable dt = new DataTable();
                dt = db.getData("SELECT * FROM tblNguoiDung WHERE TenDangNhap = '" + tendangnhap + "' AND MatKhau = '" + matkhau + "'");
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MaNguoiDung"].ToString();
                        hoten = dr["HoTen"].ToString();
                        quyen = dr["Quyen"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
         
            return id;
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            MaNguoiDung = getID(textTenDangNhap.Text,textMatKhau.Text);
            if (MaNguoiDung != "")
            {
                formMain fMain = new formMain();
                fMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !", "Thông báo");
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}