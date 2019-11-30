namespace PhanMemQuanLyNhaHang.Views
{
    partial class formCheBien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCheBien));
            this.cbChonBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl15 = new DevExpress.XtraEditors.GroupControl();
            this.dgvCheBien = new System.Windows.Forms.DataGridView();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXong = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyMon = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTenNL = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeuCau = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvNLHuy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).BeginInit();
            this.groupControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheBien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNLHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChonBan
            // 
            this.cbChonBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChonBan.FormattingEnabled = true;
            this.cbChonBan.Location = new System.Drawing.Point(101, 12);
            this.cbChonBan.Name = "cbChonBan";
            this.cbChonBan.Size = new System.Drawing.Size(58, 29);
            this.cbChonBan.TabIndex = 33;
            this.cbChonBan.SelectedIndexChanged += new System.EventHandler(this.CbChonBan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Chọn bàn: ";
            // 
            // groupControl15
            // 
            this.groupControl15.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl15.AppearanceCaption.Options.UseFont = true;
            this.groupControl15.Controls.Add(this.dgvCheBien);
            this.groupControl15.Location = new System.Drawing.Point(12, 49);
            this.groupControl15.Name = "groupControl15";
            this.groupControl15.Size = new System.Drawing.Size(372, 288);
            this.groupControl15.TabIndex = 44;
            this.groupControl15.Text = "Danh Sách Thực Đơn Cần Chế Biến";
            // 
            // dgvCheBien
            // 
            this.dgvCheBien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheBien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThucDon,
            this.SoLuong,
            this.XacNhan,
            this.MaThucDon});
            this.dgvCheBien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCheBien.Location = new System.Drawing.Point(2, 28);
            this.dgvCheBien.Name = "dgvCheBien";
            this.dgvCheBien.RowHeadersVisible = false;
            this.dgvCheBien.Size = new System.Drawing.Size(368, 258);
            this.dgvCheBien.TabIndex = 0;
            this.dgvCheBien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCheBien_CellClick);
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên Thực Đơn";
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.Width = 165;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // XacNhan
            // 
            this.XacNhan.DataPropertyName = "XacNhan";
            this.XacNhan.HeaderText = "Xác Nhận";
            this.XacNhan.Name = "XacNhan";
            // 
            // MaThucDon
            // 
            this.MaThucDon.DataPropertyName = "MaThucDon";
            this.MaThucDon.HeaderText = "Mã Thực Đơn";
            this.MaThucDon.Name = "MaThucDon";
            this.MaThucDon.Visible = false;
            // 
            // btnXong
            // 
            this.btnXong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXong.Appearance.Options.UseFont = true;
            this.btnXong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXong.ImageOptions.Image")));
            this.btnXong.Location = new System.Drawing.Point(165, 12);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(89, 29);
            this.btnXong.TabIndex = 45;
            this.btnXong.Text = "XONG";
            this.btnXong.Click += new System.EventHandler(this.BtnXong_Click);
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyMon.Appearance.Options.UseFont = true;
            this.btnHuyMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyMon.ImageOptions.Image")));
            this.btnHuyMon.Location = new System.Drawing.Point(260, 12);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(122, 29);
            this.btnHuyMon.TabIndex = 45;
            this.btnHuyMon.Text = "HỦY MÓN";
            this.btnHuyMon.Click += new System.EventHandler(this.BtnHuyMon_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dgvNguyenLieu);
            this.groupControl1.Location = new System.Drawing.Point(390, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(588, 605);
            this.groupControl1.TabIndex = 46;
            this.groupControl1.Text = "Danh Sách Nguyên Liệu";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNL,
            this.TenNCC,
            this.dataGridViewTextBoxColumn1,
            this.HoTen,
            this.DonGia,
            this.DonViTinh,
            this.MaNguyenLieu,
            this.MaNCC});
            this.dgvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(2, 28);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(584, 575);
            this.dgvNguyenLieu.TabIndex = 0;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNguyenLieu_CellClick);
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.HeaderText = "Tên Nguyên Liệu";
            this.TenNL.Name = "TenNL";
            this.TenNL.Width = 200;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Visible = false;
            this.TenNCC.Width = 122;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 105;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Người Nhập";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = false;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 125;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNL";
            this.MaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.Visible = false;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Visible = false;
            // 
            // textTenNL
            // 
            this.textTenNL.Enabled = false;
            this.textTenNL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenNL.Location = new System.Drawing.Point(536, 12);
            this.textTenNL.Name = "textTenNL";
            this.textTenNL.Size = new System.Drawing.Size(170, 29);
            this.textTenNL.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(388, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 21);
            this.label18.TabIndex = 19;
            this.label18.Text = "Tên Nguyên Liệu:";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoLuong.Location = new System.Drawing.Point(807, 12);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(55, 29);
            this.textSoLuong.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Số Lượng:";
            // 
            // btnYeuCau
            // 
            this.btnYeuCau.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeuCau.Appearance.Options.UseFont = true;
            this.btnYeuCau.Location = new System.Drawing.Point(868, 12);
            this.btnYeuCau.Name = "btnYeuCau";
            this.btnYeuCau.Size = new System.Drawing.Size(110, 29);
            this.btnYeuCau.TabIndex = 45;
            this.btnYeuCau.Text = "Yêu Cầu";
            this.btnYeuCau.Click += new System.EventHandler(this.BtnYeuCau_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgvNLHuy);
            this.groupControl2.Location = new System.Drawing.Point(12, 343);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(372, 311);
            this.groupControl2.TabIndex = 44;
            this.groupControl2.Text = "Danh Sách Nguyên Liệu Không Thể Cung Cấp";
            // 
            // dgvNLHuy
            // 
            this.dgvNLHuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNLHuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvNLHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNLHuy.Location = new System.Drawing.Point(2, 28);
            this.dgvNLHuy.Name = "dgvNLHuy";
            this.dgvNLHuy.RowHeadersVisible = false;
            this.dgvNLHuy.Size = new System.Drawing.Size(368, 281);
            this.dgvNLHuy.TabIndex = 0;
            this.dgvNLHuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCheBien_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNL";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Thực Đơn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 368;
            // 
            // formCheBien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.textSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTenNL);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnYeuCau);
            this.Controls.Add(this.btnHuyMon);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl15);
            this.Controls.Add(this.cbChonBan);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formCheBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chế Biến";
            this.Load += new System.EventHandler(this.FormCheBien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).EndInit();
            this.groupControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheBien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNLHuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChonBan;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl15;
        private System.Windows.Forms.DataGridView dgvCheBien;
        private DevExpress.XtraEditors.SimpleButton btnXong;
        private DevExpress.XtraEditors.SimpleButton btnHuyMon;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucDon;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.TextBox textTenNL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnYeuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvNLHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}