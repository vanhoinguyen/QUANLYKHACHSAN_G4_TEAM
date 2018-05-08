namespace QUANLYKHACHSAN_G4_TEAM.TraCuuKhachHang
{
    partial class fTimKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTimKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoaiKhach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcLoaiKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCMND);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.cmbPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbLoaiKhach);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 158);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(113, 121);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(124, 21);
            this.txtCMND.TabIndex = 34;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(559, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 31);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(182, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tra Cứu Khách Hàng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Appearance.Options.UseForeColor = true;
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.ImageOptions.Image")));
            this.btnTim.Location = new System.Drawing.Point(559, 49);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(95, 31);
            this.btnTim.TabIndex = 28;
            this.btnTim.Text = "Làm Mới";
            // 
            // cmbPhong
            // 
            this.cmbPhong.FormattingEnabled = true;
            this.cmbPhong.Location = new System.Drawing.Point(330, 95);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(189, 21);
            this.cmbPhong.TabIndex = 25;
            this.cmbPhong.SelectedIndexChanged += new System.EventHandler(this.cmbPhong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phòng";
            // 
            // cmbLoaiKhach
            // 
            this.cmbLoaiKhach.FormattingEnabled = true;
            this.cmbLoaiKhach.Location = new System.Drawing.Point(330, 59);
            this.cmbLoaiKhach.Name = "cmbLoaiKhach";
            this.cmbLoaiKhach.Size = new System.Drawing.Size(189, 21);
            this.cmbLoaiKhach.TabIndex = 23;
            this.cmbLoaiKhach.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiKhach_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(113, 82);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(124, 21);
            this.txtDiaChi.TabIndex = 15;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại Khách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(113, 43);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(124, 21);
            this.txtTenKH.TabIndex = 9;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            this.txtTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Location = new System.Drawing.Point(0, 153);
            this.gcKhachHang.MainView = this.gvKhachHang;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(693, 239);
            this.gcKhachHang.TabIndex = 0;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcMaKhachHang,
            this.grcTenKH,
            this.grcCMND,
            this.grcDiaChi,
            this.grcLoaiKhach});
            this.gvKhachHang.GridControl = this.gcKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvKhachHang_CustomDrawCell);
            this.gvKhachHang.DoubleClick += new System.EventHandler(this.gvKhachHang_DoubleClick);
            // 
            // grcMaKhachHang
            // 
            this.grcMaKhachHang.Caption = "Mã Khách Hàng";
            this.grcMaKhachHang.FieldName = "MaKH";
            this.grcMaKhachHang.Name = "grcMaKhachHang";
            this.grcMaKhachHang.Visible = true;
            this.grcMaKhachHang.VisibleIndex = 0;
            // 
            // grcTenKH
            // 
            this.grcTenKH.Caption = "Tên Khách Hàng";
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
            this.grcDiaChi.Caption = "DiaChi";
            this.grcDiaChi.FieldName = "DiaChi";
            this.grcDiaChi.Name = "grcDiaChi";
            this.grcDiaChi.Visible = true;
            this.grcDiaChi.VisibleIndex = 3;
            // 
            // grcLoaiKhach
            // 
            this.grcLoaiKhach.Caption = "Loại Khách";
            this.grcLoaiKhach.FieldName = "LoaiKhach";
            this.grcLoaiKhach.Name = "grcLoaiKhach";
            this.grcLoaiKhach.Visible = true;
            this.grcLoaiKhach.VisibleIndex = 4;
            // 
            // fTimKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 392);
            this.Controls.Add(this.gcKhachHang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTimKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu khách hàng";
            this.Load += new System.EventHandler(this.fTimKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLoaiKhach;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCMND;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn grcTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn grcCMND;
        private DevExpress.XtraGrid.Columns.GridColumn grcDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn grcLoaiKhach;
    }
}