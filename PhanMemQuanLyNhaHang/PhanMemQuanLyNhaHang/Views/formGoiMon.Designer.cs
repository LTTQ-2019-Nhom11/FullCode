namespace PhanMemQuanLyNhaHang.Views
{
    partial class formGoiMon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGoiMon));
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lvThucDon = new System.Windows.Forms.ListView();
            this.clThucDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaThucDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clXacNhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChonBan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiThucDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl15 = new DevExpress.XtraEditors.GroupControl();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nudSoKhach = new System.Windows.Forms.NumericUpDown();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDuaMon = new System.Windows.Forms.DataGridView();
            this.banxong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvHuyMon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnGoiMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaMon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).BeginInit();
            this.groupControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuaMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(447, 74);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(48, 29);
            this.nudSoLuong.TabIndex = 41;
            // 
            // lvThucDon
            // 
            this.lvThucDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clThucDon,
            this.clDonGia,
            this.clSoLuong,
            this.clMaThucDon,
            this.clXacNhan});
            this.lvThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThucDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThucDon.GridLines = true;
            this.lvThucDon.HideSelection = false;
            this.lvThucDon.Location = new System.Drawing.Point(2, 28);
            this.lvThucDon.Name = "lvThucDon";
            this.lvThucDon.Size = new System.Drawing.Size(484, 555);
            this.lvThucDon.TabIndex = 34;
            this.lvThucDon.UseCompatibleStateImageBehavior = false;
            this.lvThucDon.View = System.Windows.Forms.View.Details;
            this.lvThucDon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LvThucDon_ItemSelectionChanged);
            // 
            // clThucDon
            // 
            this.clThucDon.Text = "Thực Đơn";
            this.clThucDon.Width = 175;
            // 
            // clDonGia
            // 
            this.clDonGia.Text = "Đơn Giá";
            this.clDonGia.Width = 120;
            // 
            // clSoLuong
            // 
            this.clSoLuong.Text = "Số Lượng";
            this.clSoLuong.Width = 90;
            // 
            // clMaThucDon
            // 
            this.clMaThucDon.Text = "Mã Thực Đơn";
            this.clMaThucDon.Width = 0;
            // 
            // clXacNhan
            // 
            this.clXacNhan.Text = "Xác Nhận";
            this.clXacNhan.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số khách: ";
            // 
            // cbChonBan
            // 
            this.cbChonBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonBan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChonBan.FormattingEnabled = true;
            this.cbChonBan.Location = new System.Drawing.Point(307, 74);
            this.cbChonBan.Name = "cbChonBan";
            this.cbChonBan.Size = new System.Drawing.Size(45, 29);
            this.cbChonBan.TabIndex = 31;
            this.cbChonBan.SelectedIndexChanged += new System.EventHandler(this.CbChonBan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bàn: ";
            // 
            // cbLoaiThucDon
            // 
            this.cbLoaiThucDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiThucDon.FormattingEnabled = true;
            this.cbLoaiThucDon.Location = new System.Drawing.Point(138, 16);
            this.cbLoaiThucDon.Name = "cbLoaiThucDon";
            this.cbLoaiThucDon.Size = new System.Drawing.Size(126, 29);
            this.cbLoaiThucDon.TabIndex = 32;
            this.cbLoaiThucDon.SelectedIndexChanged += new System.EventHandler(this.CbLoaiThucDon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Loại Thực Đơn: ";
            // 
            // groupControl15
            // 
            this.groupControl15.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl15.AppearanceCaption.Options.UseFont = true;
            this.groupControl15.Controls.Add(this.dgvThucDon);
            this.groupControl15.Location = new System.Drawing.Point(1, 74);
            this.groupControl15.Name = "groupControl15";
            this.groupControl15.Size = new System.Drawing.Size(260, 585);
            this.groupControl15.TabIndex = 43;
            this.groupControl15.Text = "Danh Sách Thực Đơn";
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucDon.Location = new System.Drawing.Point(2, 28);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.Size = new System.Drawing.Size(256, 555);
            this.dgvThucDon.TabIndex = 0;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvThucDon_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaThucDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Thực Đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Loai";
            this.dataGridViewTextBoxColumn2.HeaderText = "Loại";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TenThucDon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Thực Đơn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 270;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DonViTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn Vị Tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn Giá (VNĐ)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lvThucDon);
            this.groupControl1.Location = new System.Drawing.Point(501, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(488, 585);
            this.groupControl1.TabIndex = 44;
            this.groupControl1.Text = "Thực Đơn Đã Chọn";
            // 
            // nudSoKhach
            // 
            this.nudSoKhach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoKhach.Location = new System.Drawing.Point(359, 17);
            this.nudSoKhach.Name = "nudSoKhach";
            this.nudSoKhach.Size = new System.Drawing.Size(48, 29);
            this.nudSoKhach.TabIndex = 41;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dgvDuaMon);
            this.groupControl2.Location = new System.Drawing.Point(265, 233);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(232, 210);
            this.groupControl2.TabIndex = 43;
            this.groupControl2.Text = "Đưa Món Ăn";
            // 
            // dgvDuaMon
            // 
            this.dgvDuaMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuaMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.banxong});
            this.dgvDuaMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuaMon.Location = new System.Drawing.Point(2, 28);
            this.dgvDuaMon.Name = "dgvDuaMon";
            this.dgvDuaMon.RowHeadersVisible = false;
            this.dgvDuaMon.Size = new System.Drawing.Size(228, 180);
            this.dgvDuaMon.TabIndex = 0;
            this.dgvDuaMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvThucDon_CellClick);
            // 
            // banxong
            // 
            this.banxong.DataPropertyName = "MaBanAn";
            this.banxong.HeaderText = "Bàn Đã Chế Biến Xong";
            this.banxong.Name = "banxong";
            this.banxong.Width = 225;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.dgvHuyMon);
            this.groupControl3.Location = new System.Drawing.Point(265, 449);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(232, 210);
            this.groupControl3.TabIndex = 43;
            this.groupControl3.Text = "Hủy Món Ăn";
            // 
            // dgvHuyMon
            // 
            this.dgvHuyMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuyMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.TenThucDon});
            this.dgvHuyMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHuyMon.Location = new System.Drawing.Point(2, 28);
            this.dgvHuyMon.Name = "dgvHuyMon";
            this.dgvHuyMon.RowHeadersVisible = false;
            this.dgvHuyMon.Size = new System.Drawing.Size(228, 180);
            this.dgvHuyMon.TabIndex = 0;
            this.dgvHuyMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvThucDon_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaBanAn";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bàn";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Thực Đơn";
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.Width = 175;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "VNĐ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(816, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 21);
            this.lblTime.TabIndex = 45;
            this.lblTime.Text = "time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(888, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 21);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "date";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.lblDate);
            this.groupControl4.Controls.Add(this.lblTime);
            this.groupControl4.Controls.Add(this.lbTongTien);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Controls.Add(this.cbLoaiThucDon);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Controls.Add(this.nudSoKhach);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(986, 65);
            this.groupControl4.TabIndex = 46;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(510, 19);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(0, 21);
            this.lbTongTien.TabIndex = 25;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.Image")));
            this.btnThanhToan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThanhToan.Location = new System.Drawing.Point(395, 171);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(100, 56);
            this.btnThanhToan.TabIndex = 40;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiMon.Appearance.Options.UseFont = true;
            this.btnGoiMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiMon.ImageOptions.Image")));
            this.btnGoiMon.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnGoiMon.Location = new System.Drawing.Point(267, 171);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(100, 56);
            this.btnGoiMon.TabIndex = 39;
            this.btnGoiMon.Text = "GỌI MÓN";
            this.btnGoiMon.Click += new System.EventHandler(this.BtnGoiMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Appearance.Options.UseFont = true;
            this.btnXoaMon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.ImageOptions.Image")));
            this.btnXoaMon.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoaMon.Location = new System.Drawing.Point(395, 109);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(100, 56);
            this.btnXoaMon.TabIndex = 38;
            this.btnXoaMon.Text = "XÓA MÓN ĂN";
            this.btnXoaMon.Click += new System.EventHandler(this.BtnXoaMon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(267, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 56);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "THÊM MÓN ĂN";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // formGoiMon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl15);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnGoiMon);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbChonBan);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formGoiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi Món";
            this.Load += new System.EventHandler(this.FormGoiMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).EndInit();
            this.groupControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuaMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuyMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnGoiMon;
        private DevExpress.XtraEditors.SimpleButton btnXoaMon;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.ListView lvThucDon;
        private System.Windows.Forms.ColumnHeader clThucDon;
        private System.Windows.Forms.ColumnHeader clDonGia;
        private System.Windows.Forms.ColumnHeader clSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChonBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiThucDon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl15;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.NumericUpDown nudSoKhach;
        private System.Windows.Forms.ColumnHeader clMaThucDon;
        private System.Windows.Forms.ColumnHeader clXacNhan;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvDuaMon;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvHuyMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn banxong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
    }
}