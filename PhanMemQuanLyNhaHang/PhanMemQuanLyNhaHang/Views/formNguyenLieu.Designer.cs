namespace PhanMemQuanLyNhaHang.Views
{
    partial class formNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNguyenLieu));
            this.groupControl15 = new DevExpress.XtraEditors.GroupControl();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.textNguoiNhap = new System.Windows.Forms.TextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl17 = new DevExpress.XtraEditors.GroupControl();
            this.btnDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.textTim_TenNL = new System.Windows.Forms.TextBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.label19 = new System.Windows.Forms.Label();
            this.grXuLy = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl18 = new DevExpress.XtraEditors.GroupControl();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.textDonGia = new System.Windows.Forms.TextBox();
            this.textDonViTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.textTenNL = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).BeginInit();
            this.groupControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).BeginInit();
            this.groupControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grXuLy)).BeginInit();
            this.grXuLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl18)).BeginInit();
            this.groupControl18.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl15
            // 
            this.groupControl15.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl15.AppearanceCaption.Options.UseFont = true;
            this.groupControl15.Controls.Add(this.dgvNguyenLieu);
            this.groupControl15.Location = new System.Drawing.Point(1, 2);
            this.groupControl15.Name = "groupControl15";
            this.groupControl15.Size = new System.Drawing.Size(586, 665);
            this.groupControl15.TabIndex = 21;
            this.groupControl15.Text = "Danh Sách Nguyên Liệu";
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNL,
            this.TenNCC,
            this.SoLuong,
            this.HoTen,
            this.DonGia,
            this.DonViTinh,
            this.MaNguyenLieu,
            this.MaNCC});
            this.dgvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(2, 28);
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.RowHeadersVisible = false;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(582, 635);
            this.dgvNguyenLieu.TabIndex = 0;
            this.dgvNguyenLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNguyenLieu_CellClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 21);
            this.label17.TabIndex = 27;
            this.label17.Text = "Mã Nhà Cung Cấp:";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(7, 218);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(78, 21);
            this.lbMatKhau.TabIndex = 26;
            this.lbMatKhau.Text = "Đơn Giá:";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Enabled = false;
            this.textSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSoLuong.Location = new System.Drawing.Point(173, 110);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(214, 29);
            this.textSoLuong.TabIndex = 22;
            // 
            // textNguoiNhap
            // 
            this.textNguoiNhap.Enabled = false;
            this.textNguoiNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNguoiNhap.Location = new System.Drawing.Point(173, 145);
            this.textNguoiNhap.Name = "textNguoiNhap";
            this.textNguoiNhap.Size = new System.Drawing.Size(214, 29);
            this.textNguoiNhap.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(900, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupControl17
            // 
            this.groupControl17.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl17.AppearanceCaption.Options.UseFont = true;
            this.groupControl17.Controls.Add(this.btnDanhSach);
            this.groupControl17.Controls.Add(this.textTim_TenNL);
            this.groupControl17.Controls.Add(this.btnTim);
            this.groupControl17.Controls.Add(this.label19);
            this.groupControl17.Location = new System.Drawing.Point(591, 2);
            this.groupControl17.Name = "groupControl17";
            this.groupControl17.Size = new System.Drawing.Size(398, 135);
            this.groupControl17.TabIndex = 24;
            this.groupControl17.Text = "Tra Cứu Nguyên Liệu";
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Appearance.Options.UseFont = true;
            this.btnDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSach.ImageOptions.Image")));
            this.btnDanhSach.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDanhSach.Location = new System.Drawing.Point(117, 74);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(129, 39);
            this.btnDanhSach.TabIndex = 23;
            this.btnDanhSach.Text = "Danh Sách";
            this.btnDanhSach.Click += new System.EventHandler(this.BtnDanhSach_Click);
            // 
            // textTim_TenNL
            // 
            this.textTim_TenNL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTim_TenNL.Location = new System.Drawing.Point(176, 39);
            this.textTim_TenNL.Name = "textTim_TenNL";
            this.textTim_TenNL.Size = new System.Drawing.Size(205, 29);
            this.textTim_TenNL.TabIndex = 20;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTim.Location = new System.Drawing.Point(252, 74);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 39);
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 21);
            this.label19.TabIndex = 19;
            this.label19.Text = "Tên Nguyên Liệu:";
            // 
            // grXuLy
            // 
            this.grXuLy.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grXuLy.AppearanceCaption.Options.UseFont = true;
            this.grXuLy.Controls.Add(this.btnXoa);
            this.grXuLy.Controls.Add(this.btnSua);
            this.grXuLy.Controls.Add(this.btnThem);
            this.grXuLy.Location = new System.Drawing.Point(591, 495);
            this.grXuLy.Name = "grXuLy";
            this.grXuLy.Size = new System.Drawing.Size(398, 170);
            this.grXuLy.TabIndex = 23;
            this.grXuLy.Text = "Xử Lý";
            this.grXuLy.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(288, 66);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 60);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA NL";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(159, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 60);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "SỬA NL";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(38, 66);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 60);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "THÊM NL";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(767, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 38);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupControl18
            // 
            this.groupControl18.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl18.AppearanceCaption.Options.UseFont = true;
            this.groupControl18.Controls.Add(this.cbMaNCC);
            this.groupControl18.Controls.Add(this.label17);
            this.groupControl18.Controls.Add(this.lbMatKhau);
            this.groupControl18.Controls.Add(this.textDonGia);
            this.groupControl18.Controls.Add(this.textSoLuong);
            this.groupControl18.Controls.Add(this.textNguoiNhap);
            this.groupControl18.Controls.Add(this.textDonViTinh);
            this.groupControl18.Controls.Add(this.label2);
            this.groupControl18.Controls.Add(this.label1);
            this.groupControl18.Controls.Add(this.lbTenDangNhap);
            this.groupControl18.Controls.Add(this.textTenNL);
            this.groupControl18.Controls.Add(this.label18);
            this.groupControl18.Location = new System.Drawing.Point(591, 143);
            this.groupControl18.Name = "groupControl18";
            this.groupControl18.Size = new System.Drawing.Size(398, 302);
            this.groupControl18.TabIndex = 22;
            this.groupControl18.Text = "Thông Tin Nguyên Liệu";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNCC.Enabled = false;
            this.cbMaNCC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(176, 75);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(214, 29);
            this.cbMaNCC.TabIndex = 33;
            // 
            // textDonGia
            // 
            this.textDonGia.Enabled = false;
            this.textDonGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDonGia.Location = new System.Drawing.Point(173, 215);
            this.textDonGia.Name = "textDonGia";
            this.textDonGia.Size = new System.Drawing.Size(214, 29);
            this.textDonGia.TabIndex = 22;
            // 
            // textDonViTinh
            // 
            this.textDonViTinh.Enabled = false;
            this.textDonViTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDonViTinh.Location = new System.Drawing.Point(173, 180);
            this.textDonViTinh.Name = "textDonViTinh";
            this.textDonViTinh.Size = new System.Drawing.Size(214, 29);
            this.textDonViTinh.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số Lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Người Nhập:";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenDangNhap.Location = new System.Drawing.Point(7, 183);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(110, 21);
            this.lbTenDangNhap.TabIndex = 21;
            this.lbTenDangNhap.Text = "Đơn Vị Tính:";
            // 
            // textTenNL
            // 
            this.textTenNL.Enabled = false;
            this.textTenNL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenNL.Location = new System.Drawing.Point(176, 40);
            this.textTenNL.Name = "textTenNL";
            this.textTenNL.Size = new System.Drawing.Size(214, 29);
            this.textTenNL.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 21);
            this.label18.TabIndex = 17;
            this.label18.Text = "Tên Nguyên Liệu:";
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.HeaderText = "Tên Nguyên Liệu";
            this.TenNL.Name = "TenNL";
            this.TenNL.Width = 175;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 122;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 90;
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
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 90;
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
            // formNguyenLieu
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.groupControl15);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl17);
            this.Controls.Add(this.grXuLy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl18);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên Liệu";
            this.Load += new System.EventHandler(this.FormNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).EndInit();
            this.groupControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).EndInit();
            this.groupControl17.ResumeLayout(false);
            this.groupControl17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grXuLy)).EndInit();
            this.grXuLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl18)).EndInit();
            this.groupControl18.ResumeLayout(false);
            this.groupControl18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl15;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox textSoLuong;
        private System.Windows.Forms.TextBox textNguoiNhap;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl groupControl17;
        private System.Windows.Forms.TextBox textTim_TenNL;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.GroupControl grXuLy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl18;
        private System.Windows.Forms.TextBox textDonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.TextBox textTenNL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private DevExpress.XtraEditors.SimpleButton btnDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}