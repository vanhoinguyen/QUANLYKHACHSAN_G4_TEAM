namespace QuanLiKhachSan.UserControl
{
    partial class frmQuanLiPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnThemPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaPhong = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSachPhong = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.grcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(417, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(91, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(441, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(764, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 56);
            this.label6.TabIndex = 5;
            this.label6.Text = "THÔNG TIN PHÒNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(196, 81);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(191, 27);
            this.txtMaPhong.TabIndex = 6;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(527, 81);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(204, 27);
            this.txtTinhTrang.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(527, 136);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(204, 27);
            this.txtDonGia.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(847, 81);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(326, 82);
            this.txtGhiChu.TabIndex = 9;
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(196, 136);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(191, 27);
            this.cmbLoaiPhong.TabIndex = 10;
            this.cmbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedIndexChanged);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemPhong.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnThemPhong.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnThemPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemPhong.Appearance.Options.UseBackColor = true;
            this.btnThemPhong.Appearance.Options.UseBorderColor = true;
            this.btnThemPhong.Appearance.Options.UseFont = true;
            this.btnThemPhong.Appearance.Options.UseForeColor = true;
            this.btnThemPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThemPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhong.ImageOptions.Image")));
            this.btnThemPhong.Location = new System.Drawing.Point(445, 197);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(173, 54);
            this.btnThemPhong.TabIndex = 11;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnLuu.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnLuu.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseBorderColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(675, 197);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 54);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnCapNhat.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnCapNhat.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Appearance.Options.UseBackColor = true;
            this.btnCapNhat.Appearance.Options.UseBorderColor = true;
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Appearance.Options.UseForeColor = true;
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(847, 197);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(134, 54);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoaPhong.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnXoaPhong.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnXoaPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPhong.Appearance.Options.UseBackColor = true;
            this.btnXoaPhong.Appearance.Options.UseBorderColor = true;
            this.btnXoaPhong.Appearance.Options.UseFont = true;
            this.btnXoaPhong.Appearance.Options.UseForeColor = true;
            this.btnXoaPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXoaPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhong.ImageOptions.Image")));
            this.btnXoaPhong.Location = new System.Drawing.Point(1014, 197);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(159, 54);
            this.btnXoaPhong.TabIndex = 14;
            this.btnXoaPhong.Text = "Xóa phòng";
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // gcDanhSachPhong
            // 
            this.gcDanhSachPhong.Location = new System.Drawing.Point(92, 272);
            this.gcDanhSachPhong.MainView = this.gvDanhSachPhong;
            this.gcDanhSachPhong.Name = "gcDanhSachPhong";
            this.gcDanhSachPhong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcDanhSachPhong.Size = new System.Drawing.Size(1081, 320);
            this.gcDanhSachPhong.TabIndex = 15;
            this.gcDanhSachPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachPhong});
            // 
            // gvDanhSachPhong
            // 
            this.gvDanhSachPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcMaPhong,
            this.grcLoaiPhong,
            this.grcTinhTrang,
            this.grcDonGia,
            this.grcGhiChu});
            this.gvDanhSachPhong.GridControl = this.gcDanhSachPhong;
            this.gvDanhSachPhong.Name = "gvDanhSachPhong";
            this.gvDanhSachPhong.OptionsBehavior.Editable = false;
            this.gvDanhSachPhong.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachPhong.Click += new System.EventHandler(this.gvDanhSachPhong_Click);
            // 
            // grcMaPhong
            // 
            this.grcMaPhong.Caption = "Mã Phòng";
            this.grcMaPhong.FieldName = "MaPhong";
            this.grcMaPhong.Name = "grcMaPhong";
            this.grcMaPhong.Visible = true;
            this.grcMaPhong.VisibleIndex = 0;
            // 
            // grcLoaiPhong
            // 
            this.grcLoaiPhong.Caption = "Loại Phòng";
            this.grcLoaiPhong.FieldName = "TenLoaiPhong";
            this.grcLoaiPhong.Name = "grcLoaiPhong";
            this.grcLoaiPhong.Visible = true;
            this.grcLoaiPhong.VisibleIndex = 1;
            // 
            // grcTinhTrang
            // 
            this.grcTinhTrang.Caption = "Tình Trạng";
            this.grcTinhTrang.FieldName = "TinhTrang";
            this.grcTinhTrang.Name = "grcTinhTrang";
            this.grcTinhTrang.Visible = true;
            this.grcTinhTrang.VisibleIndex = 2;
            // 
            // grcDonGia
            // 
            this.grcDonGia.Caption = "Đơn Gía";
            this.grcDonGia.ColumnEdit = this.repositoryItemTextEdit1;
            this.grcDonGia.FieldName = "DonGia";
            this.grcDonGia.Name = "grcDonGia";
            this.grcDonGia.Visible = true;
            this.grcDonGia.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "0,0 VNĐ";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // grcGhiChu
            // 
            this.grcGhiChu.Caption = "Ghi Chú";
            this.grcGhiChu.FieldName = "GhiChu";
            this.grcGhiChu.Name = "grcGhiChu";
            this.grcGhiChu.Visible = true;
            this.grcGhiChu.VisibleIndex = 4;
            // 
            // frmQuanLiPhong
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDanhSachPhong);
            this.Controls.Add(this.btnXoaPhong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiPhong";
            this.Size = new System.Drawing.Size(1201, 595);
            this.Load += new System.EventHandler(this.frmQuanLiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private DevExpress.XtraEditors.SimpleButton btnThemPhong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoaPhong;
        private DevExpress.XtraGrid.GridControl gcDanhSachPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn grcGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
