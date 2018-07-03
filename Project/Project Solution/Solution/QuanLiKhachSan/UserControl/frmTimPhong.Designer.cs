namespace QuanLiKhachSan.UserControl
{
    partial class frmTimPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimPhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGiaTu = new System.Windows.Forms.TextBox();
            this.txtDonGiaDen = new System.Windows.Forms.TextBox();
            this.btnTimTatCa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatPhong = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimPhongTraGanNhat = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSachPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNgayTraPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(245, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(639, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(249, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn giá từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(665, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(355, 70);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(250, 27);
            this.cmbLoaiPhong.TabIndex = 11;
            this.cmbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedIndexChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(717, 65);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(262, 59);
            this.txtGhiChu.TabIndex = 12;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // txtDonGiaTu
            // 
            this.txtDonGiaTu.Location = new System.Drawing.Point(355, 139);
            this.txtDonGiaTu.Name = "txtDonGiaTu";
            this.txtDonGiaTu.Size = new System.Drawing.Size(250, 27);
            this.txtDonGiaTu.TabIndex = 13;
            this.txtDonGiaTu.TextChanged += new System.EventHandler(this.txtDonGiaTu_TextChanged);
            this.txtDonGiaTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaTu_KeyPress);
            // 
            // txtDonGiaDen
            // 
            this.txtDonGiaDen.Location = new System.Drawing.Point(717, 139);
            this.txtDonGiaDen.Name = "txtDonGiaDen";
            this.txtDonGiaDen.Size = new System.Drawing.Size(262, 27);
            this.txtDonGiaDen.TabIndex = 14;
            this.txtDonGiaDen.TextChanged += new System.EventHandler(this.txtDonGiaDen_TextChanged);
            this.txtDonGiaDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaDen_KeyPress);
            // 
            // btnTimTatCa
            // 
            this.btnTimTatCa.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimTatCa.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnTimTatCa.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnTimTatCa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTatCa.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimTatCa.Appearance.Options.UseBackColor = true;
            this.btnTimTatCa.Appearance.Options.UseBorderColor = true;
            this.btnTimTatCa.Appearance.Options.UseFont = true;
            this.btnTimTatCa.Appearance.Options.UseForeColor = true;
            this.btnTimTatCa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTimTatCa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimTatCa.ImageOptions.Image")));
            this.btnTimTatCa.Location = new System.Drawing.Point(355, 185);
            this.btnTimTatCa.Name = "btnTimTatCa";
            this.btnTimTatCa.Size = new System.Drawing.Size(250, 54);
            this.btnTimTatCa.TabIndex = 26;
            this.btnTimTatCa.Text = "Tìm tất cả";
            this.btnTimTatCa.Click += new System.EventHandler(this.btnTimTatCa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnLamMoi.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnLamMoi.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Appearance.Options.UseBackColor = true;
            this.btnLamMoi.Appearance.Options.UseBorderColor = true;
            this.btnLamMoi.Appearance.Options.UseFont = true;
            this.btnLamMoi.Appearance.Options.UseForeColor = true;
            this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(1008, 139);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(162, 54);
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnDatPhong.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnDatPhong.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDatPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDatPhong.Appearance.Options.UseBackColor = true;
            this.btnDatPhong.Appearance.Options.UseBorderColor = true;
            this.btnDatPhong.Appearance.Options.UseFont = true;
            this.btnDatPhong.Appearance.Options.UseForeColor = true;
            this.btnDatPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDatPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.Image")));
            this.btnDatPhong.Location = new System.Drawing.Point(1008, 65);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(162, 59);
            this.btnDatPhong.TabIndex = 23;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnTimPhongTraGanNhat
            // 
            this.btnTimPhongTraGanNhat.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnTimPhongTraGanNhat.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnTimPhongTraGanNhat.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnTimPhongTraGanNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhongTraGanNhat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTimPhongTraGanNhat.Appearance.Options.UseBackColor = true;
            this.btnTimPhongTraGanNhat.Appearance.Options.UseBorderColor = true;
            this.btnTimPhongTraGanNhat.Appearance.Options.UseFont = true;
            this.btnTimPhongTraGanNhat.Appearance.Options.UseForeColor = true;
            this.btnTimPhongTraGanNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTimPhongTraGanNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimPhongTraGanNhat.ImageOptions.Image")));
            this.btnTimPhongTraGanNhat.Location = new System.Drawing.Point(717, 185);
            this.btnTimPhongTraGanNhat.Name = "btnTimPhongTraGanNhat";
            this.btnTimPhongTraGanNhat.Size = new System.Drawing.Size(262, 54);
            this.btnTimPhongTraGanNhat.TabIndex = 22;
            this.btnTimPhongTraGanNhat.Text = "Tìm phòng trả gần nhất";
            this.btnTimPhongTraGanNhat.Click += new System.EventHandler(this.btnTimPhongTraGanNhat_Click);
            // 
            // gcDanhSachPhong
            // 
            this.gcDanhSachPhong.Location = new System.Drawing.Point(148, 268);
            this.gcDanhSachPhong.MainView = this.gvPhong;
            this.gcDanhSachPhong.Name = "gcDanhSachPhong";
            this.gcDanhSachPhong.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gcDanhSachPhong.Size = new System.Drawing.Size(1022, 332);
            this.gcDanhSachPhong.TabIndex = 27;
            this.gcDanhSachPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gvPhong.GridControl = this.gcDanhSachPhong;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsBehavior.Editable = false;
            this.gvPhong.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvPhong_CustomDrawCell);
            this.gvPhong.Click += new System.EventHandler(this.gvPhong_Click);
            // 
            // grcMaPhong
            // 
            this.grcMaPhong.Caption = "Mã Phòng";
            this.grcMaPhong.FieldName = "MaPhong";
            this.grcMaPhong.Name = "grcMaPhong";
            this.grcMaPhong.Visible = true;
            this.grcMaPhong.VisibleIndex = 0;
            // 
            // grcTinhTrang
            // 
            this.grcTinhTrang.Caption = "Tình Trạng";
            this.grcTinhTrang.FieldName = "TinhTrang";
            this.grcTinhTrang.Name = "grcTinhTrang";
            this.grcTinhTrang.Visible = true;
            this.grcTinhTrang.VisibleIndex = 1;
            // 
            // grcLoaiPhong
            // 
            this.grcLoaiPhong.Caption = "Loại Phòng";
            this.grcLoaiPhong.FieldName = "TenLoaiPhong";
            this.grcLoaiPhong.Name = "grcLoaiPhong";
            this.grcLoaiPhong.Visible = true;
            this.grcLoaiPhong.VisibleIndex = 2;
            // 
            // grcDonGia
            // 
            this.grcDonGia.Caption = "Đơn giá";
            this.grcDonGia.ColumnEdit = this.repositoryItemTextEdit1;
            this.grcDonGia.FieldName = "DonGia";
            this.grcDonGia.Name = "grcDonGia";
            this.grcDonGia.Visible = true;
            this.grcDonGia.VisibleIndex = 3;
            // 
            // grcGhiChu
            // 
            this.grcGhiChu.Caption = "Ghi Chú";
            this.grcGhiChu.FieldName = "GhiChu";
            this.grcGhiChu.Name = "grcGhiChu";
            this.grcGhiChu.Visible = true;
            this.grcGhiChu.VisibleIndex = 4;
            // 
            // grcNgayTraPhong
            // 
            this.grcNgayTraPhong.Caption = "Ngày Trả Phòng";
            this.grcNgayTraPhong.FieldName = "NgayTraPhongDK";
            this.grcNgayTraPhong.Name = "grcNgayTraPhong";
            this.grcNgayTraPhong.Visible = true;
            this.grcNgayTraPhong.VisibleIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 62);
            this.label6.TabIndex = 7;
            this.label6.Text = "TRA CỨU PHÒNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "0,0 VNĐ";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // frmTimPhong
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDanhSachPhong);
            this.Controls.Add(this.btnTimTatCa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnTimPhongTraGanNhat);
            this.Controls.Add(this.txtDonGiaDen);
            this.Controls.Add(this.txtDonGiaTu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cmbLoaiPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimPhong";
            this.Size = new System.Drawing.Size(1201, 625);
            this.Load += new System.EventHandler(this.frmTimPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGiaTu;
        private System.Windows.Forms.TextBox txtDonGiaDen;
        private DevExpress.XtraEditors.SimpleButton btnTimTatCa;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnDatPhong;
        private DevExpress.XtraEditors.SimpleButton btnTimPhongTraGanNhat;
        private DevExpress.XtraGrid.GridControl gcDanhSachPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn grcLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn grcGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn grcNgayTraPhong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}
