namespace PhanMemQuanLyNhaHang.Views
{
    partial class formThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThucDon));
            this.groupControl15 = new DevExpress.XtraEditors.GroupControl();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.MaThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl18 = new DevExpress.XtraEditors.GroupControl();
            this.cbLoaiThucDon = new System.Windows.Forms.ComboBox();
            this.textTenThucDon = new System.Windows.Forms.TextBox();
            this.textDonViTinh = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textDonGia = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.grXuLy = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl17 = new DevExpress.XtraEditors.GroupControl();
            this.cbTim_LoaiThucDon = new System.Windows.Forms.ComboBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.textTim_TenThucDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDanhSach = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).BeginInit();
            this.groupControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl18)).BeginInit();
            this.groupControl18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grXuLy)).BeginInit();
            this.grXuLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).BeginInit();
            this.groupControl17.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl15
            // 
            this.groupControl15.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl15.AppearanceCaption.Options.UseFont = true;
            this.groupControl15.Controls.Add(this.dgvThucDon);
            this.groupControl15.Location = new System.Drawing.Point(1, 3);
            this.groupControl15.Name = "groupControl15";
            this.groupControl15.Size = new System.Drawing.Size(448, 663);
            this.groupControl15.TabIndex = 10;
            this.groupControl15.Text = "Danh Sách Thực Đơn";
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucDon,
            this.Loai,
            this.TenThucDon,
            this.DonViTinh,
            this.DonGia});
            this.dgvThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucDon.Location = new System.Drawing.Point(2, 28);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.Size = new System.Drawing.Size(444, 633);
            this.dgvThucDon.TabIndex = 0;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvThucDon_CellClick);
            // 
            // MaThucDon
            // 
            this.MaThucDon.DataPropertyName = "MaThucDon";
            this.MaThucDon.HeaderText = "Mã Thực Đơn";
            this.MaThucDon.Name = "MaThucDon";
            this.MaThucDon.Visible = false;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "Loai";
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            this.Loai.Visible = false;
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên Thực Đơn";
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.Width = 210;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá (VNĐ)";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 130;
            // 
            // groupControl18
            // 
            this.groupControl18.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl18.AppearanceCaption.Options.UseFont = true;
            this.groupControl18.Controls.Add(this.cbLoaiThucDon);
            this.groupControl18.Controls.Add(this.textTenThucDon);
            this.groupControl18.Controls.Add(this.textDonViTinh);
            this.groupControl18.Controls.Add(this.label33);
            this.groupControl18.Controls.Add(this.label28);
            this.groupControl18.Controls.Add(this.textDonGia);
            this.groupControl18.Controls.Add(this.label29);
            this.groupControl18.Controls.Add(this.label2);
            this.groupControl18.Controls.Add(this.label31);
            this.groupControl18.Location = new System.Drawing.Point(455, 172);
            this.groupControl18.Name = "groupControl18";
            this.groupControl18.Size = new System.Drawing.Size(534, 200);
            this.groupControl18.TabIndex = 11;
            this.groupControl18.Text = "Thông Tin Thực Đơn";
            // 
            // cbLoaiThucDon
            // 
            this.cbLoaiThucDon.Enabled = false;
            this.cbLoaiThucDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiThucDon.FormattingEnabled = true;
            this.cbLoaiThucDon.Location = new System.Drawing.Point(180, 42);
            this.cbLoaiThucDon.Name = "cbLoaiThucDon";
            this.cbLoaiThucDon.Size = new System.Drawing.Size(349, 29);
            this.cbLoaiThucDon.TabIndex = 17;
            // 
            // textTenThucDon
            // 
            this.textTenThucDon.Enabled = false;
            this.textTenThucDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTenThucDon.Location = new System.Drawing.Point(180, 77);
            this.textTenThucDon.Name = "textTenThucDon";
            this.textTenThucDon.Size = new System.Drawing.Size(349, 29);
            this.textTenThucDon.TabIndex = 16;
            // 
            // textDonViTinh
            // 
            this.textDonViTinh.Enabled = false;
            this.textDonViTinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDonViTinh.Location = new System.Drawing.Point(180, 112);
            this.textDonViTinh.Name = "textDonViTinh";
            this.textDonViTinh.Size = new System.Drawing.Size(349, 29);
            this.textDonViTinh.TabIndex = 16;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(22, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(130, 21);
            this.label33.TabIndex = 15;
            this.label33.Text = "Loại Thực Đơn:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(22, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 21);
            this.label28.TabIndex = 15;
            this.label28.Text = "Tên Thực Đơn:";
            // 
            // textDonGia
            // 
            this.textDonGia.Enabled = false;
            this.textDonGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDonGia.Location = new System.Drawing.Point(180, 147);
            this.textDonGia.Name = "textDonGia";
            this.textDonGia.Size = new System.Drawing.Size(298, 29);
            this.textDonGia.TabIndex = 16;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(22, 115);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(110, 21);
            this.label29.TabIndex = 15;
            this.label29.Text = "Đơn Vị Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "VNĐ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(22, 150);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 21);
            this.label31.TabIndex = 15;
            this.label31.Text = "Đơn Giá:";
            // 
            // grXuLy
            // 
            this.grXuLy.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grXuLy.AppearanceCaption.Options.UseFont = true;
            this.grXuLy.Controls.Add(this.btnXoa);
            this.grXuLy.Controls.Add(this.btnSua);
            this.grXuLy.Controls.Add(this.btnThem);
            this.grXuLy.Location = new System.Drawing.Point(455, 462);
            this.grXuLy.Name = "grXuLy";
            this.grXuLy.Size = new System.Drawing.Size(534, 202);
            this.grXuLy.TabIndex = 12;
            this.grXuLy.Text = "Xử Lý";
            this.grXuLy.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(369, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 81);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "XÓA TĐ";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(225, 58);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 81);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "SỬA TĐ";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(93, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 81);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "THÊM TĐ";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // groupControl17
            // 
            this.groupControl17.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl17.AppearanceCaption.Options.UseFont = true;
            this.groupControl17.Controls.Add(this.cbTim_LoaiThucDon);
            this.groupControl17.Controls.Add(this.btnDanhSach);
            this.groupControl17.Controls.Add(this.btnTim);
            this.groupControl17.Controls.Add(this.textTim_TenThucDon);
            this.groupControl17.Controls.Add(this.label1);
            this.groupControl17.Controls.Add(this.label27);
            this.groupControl17.Location = new System.Drawing.Point(455, 3);
            this.groupControl17.Name = "groupControl17";
            this.groupControl17.Size = new System.Drawing.Size(534, 163);
            this.groupControl17.TabIndex = 13;
            this.groupControl17.Text = "Tra Cứu Thực Đơn";
            // 
            // cbTim_LoaiThucDon
            // 
            this.cbTim_LoaiThucDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTim_LoaiThucDon.FormattingEnabled = true;
            this.cbTim_LoaiThucDon.Location = new System.Drawing.Point(180, 72);
            this.cbTim_LoaiThucDon.Name = "cbTim_LoaiThucDon";
            this.cbTim_LoaiThucDon.Size = new System.Drawing.Size(349, 29);
            this.cbTim_LoaiThucDon.TabIndex = 17;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.ImageOptions.Image")));
            this.btnTim.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTim.Location = new System.Drawing.Point(403, 107);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(126, 39);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // textTim_TenThucDon
            // 
            this.textTim_TenThucDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTim_TenThucDon.Location = new System.Drawing.Point(180, 37);
            this.textTim_TenThucDon.Name = "textTim_TenThucDon";
            this.textTim_TenThucDon.Size = new System.Drawing.Size(349, 29);
            this.textTim_TenThucDon.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loại Thực Đơn:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(22, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 21);
            this.label27.TabIndex = 15;
            this.label27.Text = "Tên Thực Đơn:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(785, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Enabled = false;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.Location = new System.Drawing.Point(903, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Appearance.Options.UseFont = true;
            this.btnDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnDanhSach.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDanhSach.Location = new System.Drawing.Point(180, 107);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(217, 39);
            this.btnDanhSach.TabIndex = 24;
            this.btnDanhSach.Text = "Danh Sách";
            this.btnDanhSach.Click += new System.EventHandler(this.BtnDanhSach_Click);
            // 
            // formThucDon
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.groupControl17);
            this.Controls.Add(this.grXuLy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl18);
            this.Controls.Add(this.groupControl15);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thực Đơn";
            this.Load += new System.EventHandler(this.FormThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl15)).EndInit();
            this.groupControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl18)).EndInit();
            this.groupControl18.ResumeLayout(false);
            this.groupControl18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grXuLy)).EndInit();
            this.grXuLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl17)).EndInit();
            this.groupControl17.ResumeLayout(false);
            this.groupControl17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl15;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private DevExpress.XtraEditors.GroupControl groupControl18;
        private System.Windows.Forms.ComboBox cbLoaiThucDon;
        private System.Windows.Forms.TextBox textTenThucDon;
        private System.Windows.Forms.TextBox textDonViTinh;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textDonGia;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.GroupControl grXuLy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl17;
        private System.Windows.Forms.TextBox textTim_TenThucDon;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.ComboBox cbTim_LoaiThucDon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private DevExpress.XtraEditors.SimpleButton btnDanhSach;
    }
}