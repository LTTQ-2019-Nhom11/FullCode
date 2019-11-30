namespace PhanMemQuanLyNhaHang.Views
{
    partial class formHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHoaDon));
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBanAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNVLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl19 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl20 = new DevExpress.XtraEditors.GroupControl();
            this.dateDen = new DevExpress.XtraEditors.DateEdit();
            this.dateTu = new DevExpress.XtraEditors.DateEdit();
            this.btnTheoKhoang = new DevExpress.XtraEditors.SimpleButton();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lbMaxTD = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.btnTheoThang = new DevExpress.XtraEditors.SimpleButton();
            this.textNam = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupControl21 = new DevExpress.XtraEditors.GroupControl();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnTheoNgay = new DevExpress.XtraEditors.SimpleButton();
            this.label37 = new System.Windows.Forms.Label();
            this.groupControl23 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl22 = new DevExpress.XtraEditors.GroupControl();
            this.btnDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.lbTongKhach = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl19)).BeginInit();
            this.groupControl19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl20)).BeginInit();
            this.groupControl20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl21)).BeginInit();
            this.groupControl21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl23)).BeginInit();
            this.groupControl23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl22)).BeginInit();
            this.groupControl22.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaThucDon,
            this.TenThucDon,
            this.DonGia,
            this.SoLuong});
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Location = new System.Drawing.Point(2, 28);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.Size = new System.Drawing.Size(333, 359);
            this.dgvCTHD.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SoHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Hóa Đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // MaThucDon
            // 
            this.MaThucDon.DataPropertyName = "MaThucDon";
            this.MaThucDon.HeaderText = "Mã Thực Đơn";
            this.MaThucDon.Name = "MaThucDon";
            this.MaThucDon.Visible = false;
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Thực Đơn";
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 80;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.MaBanAn,
            this.ThoiGianLap,
            this.SoKhach,
            this.MaNVLap,
            this.TongTien});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(2, 28);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(639, 449);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHoaDon_CellClick);
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số Hóa Đơn";
            this.SoHD.Name = "SoHD";
            this.SoHD.Width = 90;
            // 
            // MaBanAn
            // 
            this.MaBanAn.DataPropertyName = "MaBanAn";
            this.MaBanAn.HeaderText = "Bàn";
            this.MaBanAn.Name = "MaBanAn";
            this.MaBanAn.Width = 50;
            // 
            // ThoiGianLap
            // 
            this.ThoiGianLap.DataPropertyName = "ThoiGianLap";
            this.ThoiGianLap.HeaderText = "Thời Gian Lập";
            this.ThoiGianLap.Name = "ThoiGianLap";
            this.ThoiGianLap.Width = 150;
            // 
            // SoKhach
            // 
            this.SoKhach.DataPropertyName = "SoKhach";
            this.SoKhach.HeaderText = "Số Khách";
            this.SoKhach.Name = "SoKhach";
            this.SoKhach.Width = 80;
            // 
            // MaNVLap
            // 
            this.MaNVLap.DataPropertyName = "MaNVLap";
            this.MaNVLap.HeaderText = "Người Lập";
            this.MaNVLap.Name = "MaNVLap";
            this.MaNVLap.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 115;
            // 
            // groupControl19
            // 
            this.groupControl19.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl19.AppearanceCaption.Options.UseFont = true;
            this.groupControl19.Controls.Add(this.dgvHoaDon);
            this.groupControl19.Location = new System.Drawing.Point(3, 186);
            this.groupControl19.Name = "groupControl19";
            this.groupControl19.Size = new System.Drawing.Size(643, 479);
            this.groupControl19.TabIndex = 32;
            this.groupControl19.Text = "Danh Sách Hóa Đơn";
            // 
            // groupControl20
            // 
            this.groupControl20.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl20.AppearanceCaption.Options.UseFont = true;
            this.groupControl20.Controls.Add(this.dateDen);
            this.groupControl20.Controls.Add(this.dateTu);
            this.groupControl20.Controls.Add(this.btnTheoKhoang);
            this.groupControl20.Controls.Add(this.label32);
            this.groupControl20.Controls.Add(this.label34);
            this.groupControl20.Location = new System.Drawing.Point(338, 2);
            this.groupControl20.Name = "groupControl20";
            this.groupControl20.Size = new System.Drawing.Size(224, 178);
            this.groupControl20.TabIndex = 22;
            this.groupControl20.Text = "TK Theo Khoảng Ngày";
            // 
            // dateDen
            // 
            this.dateDen.EditValue = null;
            this.dateDen.Location = new System.Drawing.Point(47, 66);
            this.dateDen.Name = "dateDen";
            this.dateDen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDen.Properties.Appearance.Options.UseFont = true;
            this.dateDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDen.Size = new System.Drawing.Size(147, 28);
            this.dateDen.TabIndex = 17;
            // 
            // dateTu
            // 
            this.dateTu.EditValue = null;
            this.dateTu.Location = new System.Drawing.Point(47, 31);
            this.dateTu.Name = "dateTu";
            this.dateTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTu.Properties.Appearance.Options.UseFont = true;
            this.dateTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTu.Size = new System.Drawing.Size(147, 28);
            this.dateTu.TabIndex = 17;
            // 
            // btnTheoKhoang
            // 
            this.btnTheoKhoang.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoKhoang.Appearance.Options.UseFont = true;
            this.btnTheoKhoang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTheoKhoang.ImageOptions.Image")));
            this.btnTheoKhoang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTheoKhoang.Location = new System.Drawing.Point(5, 101);
            this.btnTheoKhoang.Name = "btnTheoKhoang";
            this.btnTheoKhoang.Size = new System.Drawing.Size(189, 65);
            this.btnTheoKhoang.TabIndex = 18;
            this.btnTheoKhoang.Text = "TK Theo Khoảng";
            this.btnTheoKhoang.Click += new System.EventHandler(this.BtnTheoKhoang_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(5, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 21);
            this.label32.TabIndex = 15;
            this.label32.Text = "Đến:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 34);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 21);
            this.label34.TabIndex = 15;
            this.label34.Text = "Từ:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(568, 159);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(143, 21);
            this.label43.TabIndex = 25;
            this.label43.Text = "Tổng Doanh Thu:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(568, 138);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(143, 21);
            this.label42.TabIndex = 26;
            this.label42.Text = "Tổng Khách Đến:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Red;
            this.label41.Location = new System.Drawing.Point(568, 101);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 22);
            this.label41.TabIndex = 27;
            this.label41.Text = "null";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(568, 68);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(206, 21);
            this.label40.TabIndex = 28;
            this.label40.Text = "Đồ Uống Bán Nhiếu Nhất:";
            // 
            // lbMaxTD
            // 
            this.lbMaxTD.AutoSize = true;
            this.lbMaxTD.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTD.ForeColor = System.Drawing.Color.Red;
            this.lbMaxTD.Location = new System.Drawing.Point(568, 33);
            this.lbMaxTD.Name = "lbMaxTD";
            this.lbMaxTD.Size = new System.Drawing.Size(44, 22);
            this.lbMaxTD.TabIndex = 29;
            this.lbMaxTD.Text = "null";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(568, 2);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(214, 21);
            this.label38.TabIndex = 30;
            this.label38.Text = "Thực Đơn Bán Nhiếu Nhất:";
            // 
            // btnTheoThang
            // 
            this.btnTheoThang.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoThang.Appearance.Options.UseFont = true;
            this.btnTheoThang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTheoThang.ImageOptions.Image")));
            this.btnTheoThang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTheoThang.Location = new System.Drawing.Point(5, 101);
            this.btnTheoThang.Name = "btnTheoThang";
            this.btnTheoThang.Size = new System.Drawing.Size(144, 65);
            this.btnTheoThang.TabIndex = 18;
            this.btnTheoThang.Text = "TK Theo Tháng";
            this.btnTheoThang.Click += new System.EventHandler(this.BtnTheoThang_Click);
            // 
            // textNam
            // 
            this.textNam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNam.Location = new System.Drawing.Point(72, 66);
            this.textNam.Name = "textNam";
            this.textNam.Size = new System.Drawing.Size(77, 29);
            this.textNam.TabIndex = 19;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(5, 69);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 21);
            this.label35.TabIndex = 15;
            this.label35.Text = "Năm:";
            // 
            // cbThang
            // 
            this.cbThang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(72, 31);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(77, 29);
            this.cbThang.TabIndex = 16;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(5, 34);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 21);
            this.label36.TabIndex = 15;
            this.label36.Text = "Tháng:";
            // 
            // groupControl21
            // 
            this.groupControl21.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl21.AppearanceCaption.Options.UseFont = true;
            this.groupControl21.Controls.Add(this.btnTheoThang);
            this.groupControl21.Controls.Add(this.textNam);
            this.groupControl21.Controls.Add(this.label35);
            this.groupControl21.Controls.Add(this.cbThang);
            this.groupControl21.Controls.Add(this.label36);
            this.groupControl21.Location = new System.Drawing.Point(173, 2);
            this.groupControl21.Name = "groupControl21";
            this.groupControl21.Size = new System.Drawing.Size(159, 178);
            this.groupControl21.TabIndex = 23;
            this.groupControl21.Text = "TK Theo Tháng";
            // 
            // dateNgay
            // 
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(9, 63);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgay.Properties.Appearance.Options.UseFont = true;
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.Mask.PlaceHolder = '-';
            this.dateNgay.Size = new System.Drawing.Size(143, 28);
            this.dateNgay.TabIndex = 17;
            // 
            // btnTheoNgay
            // 
            this.btnTheoNgay.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoNgay.Appearance.Options.UseFont = true;
            this.btnTheoNgay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTheoNgay.ImageOptions.Image")));
            this.btnTheoNgay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTheoNgay.Location = new System.Drawing.Point(5, 99);
            this.btnTheoNgay.Name = "btnTheoNgay";
            this.btnTheoNgay.Size = new System.Drawing.Size(147, 65);
            this.btnTheoNgay.TabIndex = 18;
            this.btnTheoNgay.Text = "TK Theo Ngày";
            this.btnTheoNgay.Click += new System.EventHandler(this.BtnTheoNgay_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(5, 34);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 21);
            this.label37.TabIndex = 15;
            this.label37.Text = "Chọn ngày:";
            // 
            // groupControl23
            // 
            this.groupControl23.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl23.AppearanceCaption.Options.UseFont = true;
            this.groupControl23.Controls.Add(this.dgvCTHD);
            this.groupControl23.Location = new System.Drawing.Point(650, 186);
            this.groupControl23.Name = "groupControl23";
            this.groupControl23.Size = new System.Drawing.Size(337, 389);
            this.groupControl23.TabIndex = 31;
            this.groupControl23.Text = "Chi Tiết Hóa Đơn";
            // 
            // groupControl22
            // 
            this.groupControl22.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl22.AppearanceCaption.Options.UseFont = true;
            this.groupControl22.Controls.Add(this.dateNgay);
            this.groupControl22.Controls.Add(this.btnTheoNgay);
            this.groupControl22.Controls.Add(this.label37);
            this.groupControl22.Location = new System.Drawing.Point(3, 2);
            this.groupControl22.Name = "groupControl22";
            this.groupControl22.Size = new System.Drawing.Size(164, 178);
            this.groupControl22.TabIndex = 24;
            this.groupControl22.Text = "TK Theo Ngày";
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Appearance.Options.UseFont = true;
            this.btnDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhSach.ImageOptions.Image")));
            this.btnDanhSach.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDanhSach.Location = new System.Drawing.Point(762, 591);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(223, 65);
            this.btnDanhSach.TabIndex = 18;
            this.btnDanhSach.Text = "Danh Sách Hóa Đơn";
            this.btnDanhSach.Click += new System.EventHandler(this.BtnDanhSach_Click);
            // 
            // lbTongKhach
            // 
            this.lbTongKhach.AutoSize = true;
            this.lbTongKhach.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongKhach.ForeColor = System.Drawing.Color.Red;
            this.lbTongKhach.Location = new System.Drawing.Point(717, 138);
            this.lbTongKhach.Name = "lbTongKhach";
            this.lbTongKhach.Size = new System.Drawing.Size(44, 22);
            this.lbTongKhach.TabIndex = 27;
            this.lbTongKhach.Text = "null";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(717, 159);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(44, 22);
            this.lbTongTien.TabIndex = 27;
            this.lbTongTien.Text = "null";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPrint.Location = new System.Drawing.Point(650, 591);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 65);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "In HD";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // formHoaDon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.groupControl19);
            this.Controls.Add(this.groupControl20);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbTongKhach);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.lbMaxTD);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.groupControl21);
            this.Controls.Add(this.groupControl23);
            this.Controls.Add(this.groupControl22);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl19)).EndInit();
            this.groupControl19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl20)).EndInit();
            this.groupControl20.ResumeLayout(false);
            this.groupControl20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl21)).EndInit();
            this.groupControl21.ResumeLayout(false);
            this.groupControl21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl23)).EndInit();
            this.groupControl23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl22)).EndInit();
            this.groupControl22.ResumeLayout(false);
            this.groupControl22.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private DevExpress.XtraEditors.GroupControl groupControl19;
        private DevExpress.XtraEditors.GroupControl groupControl20;
        private DevExpress.XtraEditors.DateEdit dateDen;
        private DevExpress.XtraEditors.DateEdit dateTu;
        private DevExpress.XtraEditors.SimpleButton btnTheoKhoang;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lbMaxTD;
        private System.Windows.Forms.Label label38;
        private DevExpress.XtraEditors.SimpleButton btnTheoThang;
        private System.Windows.Forms.TextBox textNam;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label36;
        private DevExpress.XtraEditors.GroupControl groupControl21;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private DevExpress.XtraEditors.SimpleButton btnTheoNgay;
        private System.Windows.Forms.Label label37;
        private DevExpress.XtraEditors.GroupControl groupControl23;
        private DevExpress.XtraEditors.GroupControl groupControl22;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNVLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private DevExpress.XtraEditors.SimpleButton btnDanhSach;
        private System.Windows.Forms.Label lbTongKhach;
        private System.Windows.Forms.Label lbTongTien;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}