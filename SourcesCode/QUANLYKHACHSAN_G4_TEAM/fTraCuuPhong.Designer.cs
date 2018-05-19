namespace QUANLYKHACHSAN_G4_TEAM.TraCuuPhong
{
    partial class fTraCuuPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraCuuPhong));
            this.txtDonGiaDen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGiaTu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNgayTraPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatPhong = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTatCa = new DevExpress.XtraEditors.SimpleButton();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonGiaDen
            // 
            this.txtDonGiaDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDonGiaDen.Location = new System.Drawing.Point(327, 113);
            this.txtDonGiaDen.Name = "txtDonGiaDen";
            this.txtDonGiaDen.Size = new System.Drawing.Size(155, 23);
            this.txtDonGiaDen.TabIndex = 51;
            this.txtDonGiaDen.TextChanged += new System.EventHandler(this.txtDonGiaDen_TextChanged);
            this.txtDonGiaDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaDen_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Đến:";
            // 
            // txtDonGiaTu
            // 
            this.txtDonGiaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDonGiaTu.Location = new System.Drawing.Point(78, 112);
            this.txtDonGiaTu.Name = "txtDonGiaTu";
            this.txtDonGiaTu.Size = new System.Drawing.Size(158, 23);
            this.txtDonGiaTu.TabIndex = 50;
            this.txtDonGiaTu.TextChanged += new System.EventHandler(this.txtDonGiaTu_TextChanged);
            this.txtDonGiaTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaTu_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Đơn giá từ:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(78, 62);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(404, 48);
            this.txtGhiChu.TabIndex = 49;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // gcPhong
            // 
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcPhong.Location = new System.Drawing.Point(0, 150);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(858, 262);
            this.gcPhong.TabIndex = 48;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcMaPhong,
            this.grcTinhTrang,
            this.grcLoaiPhong,
            this.grcDonGia,
            this.grcGhiChu,
            this.grcNgayTraPhong});
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsBehavior.Editable = false;
            this.gvPhong.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvPhong_CustomDrawCell);
            this.gvPhong.Click += new System.EventHandler(this.gvPhong_Click);
            // 
            // grcMaPhong
            // 
            this.grcMaPhong.Caption = "Mã phòng";
            this.grcMaPhong.FieldName = "MaPhong";
            this.grcMaPhong.Name = "grcMaPhong";
            this.grcMaPhong.Visible = true;
            this.grcMaPhong.VisibleIndex = 0;
            // 
            // grcTinhTrang
            // 
            this.grcTinhTrang.Caption = "Tình trạng";
            this.grcTinhTrang.FieldName = "TinhTrang";
            this.grcTinhTrang.Name = "grcTinhTrang";
            this.grcTinhTrang.Visible = true;
            this.grcTinhTrang.VisibleIndex = 1;
            // 
            // grcLoaiPhong
            // 
            this.grcLoaiPhong.Caption = "Loại phòng";
            this.grcLoaiPhong.FieldName = "TenLoaiPhong";
            this.grcLoaiPhong.Name = "grcLoaiPhong";
            this.grcLoaiPhong.Visible = true;
            this.grcLoaiPhong.VisibleIndex = 2;
            // 
            // grcDonGia
            // 
            this.grcDonGia.Caption = "Đơn giá";
            this.grcDonGia.FieldName = "DonGia";
            this.grcDonGia.Name = "grcDonGia";
            this.grcDonGia.Visible = true;
            this.grcDonGia.VisibleIndex = 3;
            // 
            // grcGhiChu
            // 
            this.grcGhiChu.Caption = "Ghi chú";
            this.grcGhiChu.FieldName = "GhiChu";
            this.grcGhiChu.Name = "grcGhiChu";
            this.grcGhiChu.Visible = true;
            this.grcGhiChu.VisibleIndex = 4;
            // 
            // grcNgayTraPhong
            // 
            this.grcNgayTraPhong.Caption = "Ngày trả phòng";
            this.grcNgayTraPhong.FieldName = "NgayTraPhongDK";
            this.grcNgayTraPhong.Name = "grcNgayTraPhong";
            this.grcNgayTraPhong.Visible = true;
            this.grcNgayTraPhong.VisibleIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(656, 78);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 31);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(656, 40);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 31);
            this.btnLamMoi.TabIndex = 46;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatPhong.Appearance.Options.UseFont = true;
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.Enabled = false;
            this.btnDatPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.Image")));
            this.btnDatPhong.Location = new System.Drawing.Point(555, 78);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(95, 31);
            this.btnDatPhong.TabIndex = 45;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(261, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 31);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tra Cứu Phòng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Appearance.Options.UseFont = true;
            this.btnTatCa.Appearance.Options.UseForeColor = true;
            this.btnTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTatCa.ImageOptions.Image")));
            this.btnTatCa.Location = new System.Drawing.Point(555, 40);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(95, 31);
            this.btnTatCa.TabIndex = 43;
            this.btnTatCa.Text = "Tìm tất cả";
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(78, 40);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(404, 21);
            this.cmbLoaiPhong.TabIndex = 41;
            this.cmbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Loại Phòng";
            // 
            // fTraCuuPhong
            // 
            this.Appearance.BackColor = System.Drawing.Color.Silver;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 412);
            this.Controls.Add(this.txtDonGiaDen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGiaTu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.gcPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTraCuuPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Phòng";
            this.Load += new System.EventHandler(this.fTraCuuPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonGiaDen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGiaTu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn grcLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn grcGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn grcNgayTraPhong;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnDatPhong;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnTatCa;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}