namespace QUANLYKHACHSAN_G4_TEAM
{
    partial class fOderDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOderDichVu));
            this.btnOder = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTenDichVu = new System.Windows.Forms.ComboBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOder
            // 
            this.btnOder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOder.Appearance.Options.UseFont = true;
            this.btnOder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnOder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOder.ImageOptions.Image")));
            this.btnOder.Location = new System.Drawing.Point(170, 234);
            this.btnOder.Name = "btnOder";
            this.btnOder.Size = new System.Drawing.Size(108, 64);
            this.btnOder.TabIndex = 20;
            this.btnOder.Text = "Oder";
            this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã Phòng";
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(170, 84);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(242, 27);
            this.cmbMaPhong.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 56);
            this.label1.TabIndex = 23;
            this.label1.Text = "ĐĂNG KÍ DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(170, 177);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(242, 27);
            this.txtSoLuong.TabIndex = 26;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên Dịch Vụ";
            // 
            // cmbTenDichVu
            // 
            this.cmbTenDichVu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenDichVu.FormattingEnabled = true;
            this.cmbTenDichVu.Location = new System.Drawing.Point(170, 132);
            this.cmbTenDichVu.Name = "cmbTenDichVu";
            this.cmbTenDichVu.Size = new System.Drawing.Size(242, 27);
            this.cmbTenDichVu.TabIndex = 28;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(313, 234);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 64);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fOderDichVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 333);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cmbTenDichVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fOderDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oder dịch vụ";
            this.Load += new System.EventHandler(this.fOderDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTenDichVu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}