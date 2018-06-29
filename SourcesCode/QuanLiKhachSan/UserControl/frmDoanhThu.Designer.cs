namespace QuanLiKhachSan.UserControl
{
    partial class frmDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTongDoanhThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTiLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng doanh thu";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(721, 73);
            this.label6.TabIndex = 18;
            this.label6.Text = "DOANH THU THEO TỪNG LOẠI PHÒNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(467, 85);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(162, 27);
            this.cmbThang.TabIndex = 19;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(737, 85);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(146, 27);
            this.txtNam.TabIndex = 20;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(649, 130);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(234, 27);
            this.txtTongTien.TabIndex = 21;
            // 
            // btnXem
            // 
            this.btnXem.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnXem.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnXem.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnXem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Appearance.Options.UseBackColor = true;
            this.btnXem.Appearance.Options.UseBorderColor = true;
            this.btnXem.Appearance.Options.UseFont = true;
            this.btnXem.Appearance.Options.UseForeColor = true;
            this.btnXem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(628, 186);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(141, 54);
            this.btnXem.TabIndex = 24;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "0,0 VNĐ";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcTenLoaiPhong,
            this.grcTongDoanhThu,
            this.grcThang,
            this.grcNam,
            this.grcTiLe});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // grcTenLoaiPhong
            // 
            this.grcTenLoaiPhong.Caption = "Tên Loại Phòng";
            this.grcTenLoaiPhong.FieldName = "TenLoaiPhong";
            this.grcTenLoaiPhong.Name = "grcTenLoaiPhong";
            this.grcTenLoaiPhong.Visible = true;
            this.grcTenLoaiPhong.VisibleIndex = 0;
            // 
            // grcTongDoanhThu
            // 
            this.grcTongDoanhThu.Caption = "Tổng Doanh Thu";
            this.grcTongDoanhThu.ColumnEdit = this.repositoryItemTextEdit1;
            this.grcTongDoanhThu.FieldName = "TongDoanhThu";
            this.grcTongDoanhThu.Name = "grcTongDoanhThu";
            this.grcTongDoanhThu.Visible = true;
            this.grcTongDoanhThu.VisibleIndex = 1;
            // 
            // grcThang
            // 
            this.grcThang.Caption = "Tháng";
            this.grcThang.FieldName = "Thang";
            this.grcThang.Name = "grcThang";
            this.grcThang.Visible = true;
            this.grcThang.VisibleIndex = 2;
            // 
            // grcNam
            // 
            this.grcNam.Caption = "Năm";
            this.grcNam.FieldName = "Nam";
            this.grcNam.Name = "grcNam";
            this.grcNam.Visible = true;
            this.grcNam.VisibleIndex = 3;
            // 
            // grcTiLe
            // 
            this.grcTiLe.Caption = "Tỉ Lệ";
            this.grcTiLe.FieldName = "TiLe";
            this.grcTiLe.Name = "grcTiLe";
            this.grcTiLe.Visible = true;
            this.grcTiLe.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(295, 301);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(803, 297);
            this.gridControl1.TabIndex = 25;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmDoanhThu
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoanhThu";
            this.Size = new System.Drawing.Size(1201, 625);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grcTenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcTongDoanhThu;
        private DevExpress.XtraGrid.Columns.GridColumn grcThang;
        private DevExpress.XtraGrid.Columns.GridColumn grcNam;
        private DevExpress.XtraGrid.Columns.GridColumn grcTiLe;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}
