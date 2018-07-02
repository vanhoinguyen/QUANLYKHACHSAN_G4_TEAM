namespace QuanLiKhachSan.UserControl
{
    partial class frmTraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraPhong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dtpNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSoNgayThue = new System.Windows.Forms.TextBox();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.txtPhuThu = new System.Windows.Forms.TextBox();
            this.txtPhiDichVu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnXoaHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(580, 52);
            this.label6.TabIndex = 19;
            this.label6.Text = "HÓA ĐƠN THANH TOÁN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.dtpNgayThanhToan);
            this.groupBox1.Controls.Add(this.cmbMaPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 175);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(151, 132);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(185, 27);
            this.txtDonGia.TabIndex = 5;
            // 
            // dtpNgayThanhToan
            // 
            this.dtpNgayThanhToan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThanhToan.Location = new System.Drawing.Point(151, 83);
            this.dtpNgayThanhToan.Name = "dtpNgayThanhToan";
            this.dtpNgayThanhToan.Size = new System.Drawing.Size(185, 27);
            this.dtpNgayThanhToan.TabIndex = 4;
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(151, 38);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(185, 27);
            this.cmbMaPhong.TabIndex = 3;
            this.cmbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cmbMaPhong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtTenKhachHang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(383, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 175);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(145, 86);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(200, 70);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(145, 38);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(200, 27);
            this.txtTenKhachHang.TabIndex = 6;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSoNgayThue);
            this.groupBox3.Controls.Add(this.txtHeSo);
            this.groupBox3.Controls.Add(this.txtPhuThu);
            this.groupBox3.Controls.Add(this.txtPhiDichVu);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(753, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 220);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phụ thu";
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayThue.Location = new System.Drawing.Point(137, 173);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.ReadOnly = true;
            this.txtSoNgayThue.Size = new System.Drawing.Size(150, 27);
            this.txtSoNgayThue.TabIndex = 12;
            // 
            // txtHeSo
            // 
            this.txtHeSo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSo.Location = new System.Drawing.Point(137, 129);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.ReadOnly = true;
            this.txtHeSo.Size = new System.Drawing.Size(150, 27);
            this.txtHeSo.TabIndex = 11;
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuThu.Location = new System.Drawing.Point(137, 86);
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.ReadOnly = true;
            this.txtPhuThu.Size = new System.Drawing.Size(150, 27);
            this.txtPhuThu.TabIndex = 10;
            // 
            // txtPhiDichVu
            // 
            this.txtPhiDichVu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiDichVu.Location = new System.Drawing.Point(137, 38);
            this.txtPhiDichVu.Name = "txtPhiDichVu";
            this.txtPhiDichVu.ReadOnly = true;
            this.txtPhiDichVu.Size = new System.Drawing.Size(150, 27);
            this.txtPhiDichVu.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số ngày thuê";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hệ số";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phụ thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phí dịch vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(528, 290);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(200, 27);
            this.txtTongTien.TabIndex = 13;
            this.txtTongTien.Text = "0 VNĐ";
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoaHoaDon.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnXoaHoaDon.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnXoaHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHoaDon.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXoaHoaDon.Appearance.Options.UseBackColor = true;
            this.btnXoaHoaDon.Appearance.Options.UseBorderColor = true;
            this.btnXoaHoaDon.Appearance.Options.UseFont = true;
            this.btnXoaHoaDon.Appearance.Options.UseForeColor = true;
            this.btnXoaHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXoaHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHoaDon.ImageOptions.Image")));
            this.btnXoaHoaDon.Location = new System.Drawing.Point(1094, 263);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(177, 54);
            this.btnXoaHoaDon.TabIndex = 25;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnThanhToan.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnThanhToan.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Appearance.Options.UseBackColor = true;
            this.btnThanhToan.Appearance.Options.UseBorderColor = true;
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Appearance.Options.UseForeColor = true;
            this.btnThanhToan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.ImageOptions.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(1094, 186);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(177, 54);
            this.btnThanhToan.TabIndex = 24;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnThemHoaDon.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnThemHoaDon.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnThemHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThemHoaDon.Appearance.Options.UseBackColor = true;
            this.btnThemHoaDon.Appearance.Options.UseBorderColor = true;
            this.btnThemHoaDon.Appearance.Options.UseFont = true;
            this.btnThemHoaDon.Appearance.Options.UseForeColor = true;
            this.btnThemHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThemHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHoaDon.ImageOptions.Image")));
            this.btnThemHoaDon.Location = new System.Drawing.Point(1094, 108);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(177, 54);
            this.btnThemHoaDon.TabIndex = 23;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaPhong,
            this.colSoNgayThue,
            this.colDonGia,
            this.colPhuThu,
            this.colHeSo,
            this.colThanhTien,
            this.colXoa});
            this.dgvHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvHoaDon.Location = new System.Drawing.Point(45, 347);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(995, 242);
            this.dgvHoaDon.TabIndex = 26;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.btnInHoaDon.Appearance.BackColor2 = System.Drawing.Color.SeaShell;
            this.btnInHoaDon.Appearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnInHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Appearance.Options.UseBackColor = true;
            this.btnInHoaDon.Appearance.Options.UseBorderColor = true;
            this.btnInHoaDon.Appearance.Options.UseFont = true;
            this.btnInHoaDon.Appearance.Options.UseForeColor = true;
            this.btnInHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnInHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.ImageOptions.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(200, 287);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(177, 30);
            this.btnInHoaDon.TabIndex = 27;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.Visible = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click_1);
            // 
            // colSTT
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTT.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colMaPhong
            // 
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            // 
            // colSoNgayThue
            // 
            this.colSoNgayThue.HeaderText = "Số ngày thuê";
            this.colSoNgayThue.Name = "colSoNgayThue";
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 200;
            // 
            // colPhuThu
            // 
            this.colPhuThu.HeaderText = "Phụ thu";
            this.colPhuThu.Name = "colPhuThu";
            this.colPhuThu.Width = 80;
            // 
            // colHeSo
            // 
            this.colHeSo.HeaderText = "Hệ số";
            this.colHeSo.Name = "colHeSo";
            this.colHeSo.Width = 80;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 212;
            // 
            // colXoa
            // 
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Width = 80;
            // 
            // frmTraPhong
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThemHoaDon);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraPhong";
            this.Size = new System.Drawing.Size(1282, 645);
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DateTimePicker dtpNgayThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoNgayThue;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.TextBox txtPhuThu;
        private System.Windows.Forms.TextBox txtPhiDichVu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongTien;
        private DevExpress.XtraEditors.SimpleButton btnXoaHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnThemHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        public System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXoa;
    }
}
