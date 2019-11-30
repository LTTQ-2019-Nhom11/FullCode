namespace PhanMemQuanLyNhaHang.Views
{
    partial class formXacNhanNhapNL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formXacNhanNhapNL));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvYeuCauMua = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnTuChoi = new DevExpress.XtraEditors.SimpleButton();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCauMua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dgvYeuCauMua);
            this.groupControl1.Location = new System.Drawing.Point(2, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(602, 644);
            this.groupControl1.TabIndex = 48;
            this.groupControl1.Text = "Nguyên Liệu Yêu Cầu Mua";
            // 
            // dgvYeuCauMua
            // 
            this.dgvYeuCauMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeuCauMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNguyenLieu,
            this.TenNL,
            this.dataGridViewTextBoxColumn1,
            this.DonGia,
            this.DonViTinh,
            this.XacNhan});
            this.dgvYeuCauMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYeuCauMua.Location = new System.Drawing.Point(2, 28);
            this.dgvYeuCauMua.Name = "dgvYeuCauMua";
            this.dgvYeuCauMua.RowHeadersVisible = false;
            this.dgvYeuCauMua.Size = new System.Drawing.Size(598, 614);
            this.dgvYeuCauMua.TabIndex = 0;
            this.dgvYeuCauMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvYeuCauMua_CellClick);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Appearance.Options.UseFont = true;
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnXacNhan.Location = new System.Drawing.Point(688, 110);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(207, 64);
            this.btnXacNhan.TabIndex = 52;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.BtnXacNhan_Click);
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChoi.Appearance.Options.UseFont = true;
            this.btnTuChoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTuChoi.ImageOptions.Image")));
            this.btnTuChoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnTuChoi.Location = new System.Drawing.Point(688, 289);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(207, 64);
            this.btnTuChoi.TabIndex = 52;
            this.btnTuChoi.Text = "TỪ CHỐI";
            this.btnTuChoi.Click += new System.EventHandler(this.BtnTuChoi_Click);
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.DataPropertyName = "MaNL";
            this.MaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.Visible = false;
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.HeaderText = "Tên Nguyên Liệu";
            this.TenNL.Name = "TenNL";
            this.TenNL.Width = 179;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // XacNhan
            // 
            this.XacNhan.DataPropertyName = "XacNhan";
            this.XacNhan.HeaderText = "Xác Nhận";
            this.XacNhan.Name = "XacNhan";
            // 
            // btnAll
            // 
            this.btnAll.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Appearance.Options.UseFont = true;
            this.btnAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAll.Location = new System.Drawing.Point(688, 470);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(207, 64);
            this.btnAll.TabIndex = 52;
            this.btnAll.Text = "XÁC NHẬN TẤT CẢ";
            this.btnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // formXacNhanNhapNL
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formXacNhanNhapNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác Nhận";
            this.Load += new System.EventHandler(this.FormXacNhanNhapNL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeuCauMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvYeuCauMua;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.SimpleButton btnTuChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn XacNhan;
        private DevExpress.XtraEditors.SimpleButton btnAll;
    }
}