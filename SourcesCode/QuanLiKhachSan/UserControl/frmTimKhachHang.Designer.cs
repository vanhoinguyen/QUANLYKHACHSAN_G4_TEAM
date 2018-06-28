namespace QuanLiKhachSan.UserControl
{
    partial class frmTimKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoaiKhach = new System.Windows.Forms.ComboBox();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.gcDanhSachKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLoaiKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(687, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phòng";
            // 
            // cmbLoaiKhach
            // 
            this.cmbLoaiKhach.FormattingEnabled = true;
            this.cmbLoaiKhach.Location = new System.Drawing.Point(777, 90);
            this.cmbLoaiKhach.Name = "cmbLoaiKhach";
            this.cmbLoaiKhach.Size = new System.Drawing.Size(220, 27);
            this.cmbLoaiKhach.TabIndex = 12;
            this.cmbLoaiKhach.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiKhach_SelectedIndexChanged);
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(777, 142);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(220, 27);
            this.cmbPhong.TabIndex = 13;
            this.cmbPhong.SelectedIndexChanged += new System.EventHandler(this.cmbPhong_SelectedIndexChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(350, 183);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 27);
            this.txtCMND.TabIndex = 14;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(350, 136);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 27);
            this.txtDiaChi.TabIndex = 15;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(350, 87);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(250, 27);
            this.txtTenKhachHang.TabIndex = 16;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            this.txtTenKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhachHang_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(519, 70);
            this.label6.TabIndex = 17;
            this.label6.Text = "TRA CỨU KHÁCH HÀNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnLamMoi.Location = new System.Drawing.Point(842, 183);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(155, 61);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // gcDanhSachKhachHang
            // 
            this.gcDanhSachKhachHang.Location = new System.Drawing.Point(147, 266);
            this.gcDanhSachKhachHang.MainView = this.gvKhachHang;
            this.gcDanhSachKhachHang.Name = "gcDanhSachKhachHang";
            this.gcDanhSachKhachHang.Size = new System.Drawing.Size(1022, 334);
            this.gcDanhSachKhachHang.TabIndex = 28;
            this.gcDanhSachKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            this.gcDanhSachKhachHang.DoubleClick += new System.EventHandler(this.gcDanhSachKhachHang_DoubleClick);
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcMaKhachHang,
            this.grcTenKH,
            this.grcCMND,
            this.grcDiaChi,
            this.grcLoaiKhach});
            this.gvKhachHang.GridControl = this.gcDanhSachKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.OptionsBehavior.Editable = false;
            this.gvKhachHang.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvKhachHang_CustomDrawCell);
            // 
            // grcMaKhachHang
            // 
            this.grcMaKhachHang.Caption = "Mã Khách Hàng";
            this.grcMaKhachHang.FieldName = "MaKH";
            this.grcMaKhachHang.Name = "grcMaKhachHang";
            this.grcMaKhachHang.Visible = true;
            this.grcMaKhachHang.VisibleIndex = 0;
            // 
            // grcTenKH
            // 
            this.grcTenKH.Caption = "Tên Khách Hàng";
            this.grcTenKH.FieldName = "TenKhachHang";
            this.grcTenKH.Name = "grcTenKH";
            this.grcTenKH.Visible = true;
            this.grcTenKH.VisibleIndex = 1;
            // 
            // grcCMND
            // 
            this.grcCMND.Caption = "CMND";
            this.grcCMND.FieldName = "CMND";
            this.grcCMND.Name = "grcCMND";
            this.grcCMND.Visible = true;
            this.grcCMND.VisibleIndex = 2;
            // 
            // grcDiaChi
            // 
            this.grcDiaChi.Caption = "Địa chỉ";
            this.grcDiaChi.FieldName = "DiaChi";
            this.grcDiaChi.Name = "grcDiaChi";
            this.grcDiaChi.Visible = true;
            this.grcDiaChi.VisibleIndex = 3;
            // 
            // grcLoaiKhach
            // 
            this.grcLoaiKhach.Caption = "Loại Khách";
            this.grcLoaiKhach.FieldName = "LoaiKhach";
            this.grcLoaiKhach.Name = "grcLoaiKhach";
            this.grcLoaiKhach.Visible = true;
            this.grcLoaiKhach.VisibleIndex = 4;
            // 
            // frmTimKhachHang
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcDanhSachKhachHang);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.cmbPhong);
            this.Controls.Add(this.cmbLoaiKhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKhachHang";
            this.Size = new System.Drawing.Size(1201, 625);
            this.Load += new System.EventHandler(this.frmTimKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLoaiKhach;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraGrid.GridControl gcDanhSachKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn grcTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn grcCMND;
        private DevExpress.XtraGrid.Columns.GridColumn grcDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn grcLoaiKhach;
    }
}
