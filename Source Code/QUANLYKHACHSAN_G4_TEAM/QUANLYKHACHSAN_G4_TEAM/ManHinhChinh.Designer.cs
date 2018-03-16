namespace QUANLYKHACHSAN_G4_TEAM
{
    partial class ManHinhChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManHinhChinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbHotel = new System.Windows.Forms.PictureBox();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCategoryRoom = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHotel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ptbHotel);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 372);
            this.panel1.TabIndex = 7;
            // 
            // ptbHotel
            // 
            this.ptbHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHotel.Location = new System.Drawing.Point(0, 0);
            this.ptbHotel.Name = "ptbHotel";
            this.ptbHotel.Size = new System.Drawing.Size(644, 372);
            this.ptbHotel.TabIndex = 3;
            this.ptbHotel.TabStop = false;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(16, 284);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(213, 48);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "Doanh Thu";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(16, 68);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(213, 48);
            this.btnSearchRoom.TabIndex = 1;
            this.btnSearchRoom.Text = "Tra Cứu Phòng";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnListRoom_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(16, 122);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(213, 48);
            this.btnBookRoom.TabIndex = 2;
            this.btnBookRoom.Text = "Đặt Phòng";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.Location = new System.Drawing.Point(16, 338);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(213, 48);
            this.btnExitMain.TabIndex = 5;
            this.btnExitMain.Text = "Thoát";
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(16, 176);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(213, 48);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Tính Tiền";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCategoryRoom
            // 
            this.btnCategoryRoom.Location = new System.Drawing.Point(16, 14);
            this.btnCategoryRoom.Name = "btnCategoryRoom";
            this.btnCategoryRoom.Size = new System.Drawing.Size(213, 48);
            this.btnCategoryRoom.TabIndex = 0;
            this.btnCategoryRoom.Text = "Danh Mục Phòng";
            this.btnCategoryRoom.UseVisualStyleBackColor = true;
            this.btnCategoryRoom.Click += new System.EventHandler(this.btnCategoryRoom_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(16, 230);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(213, 48);
            this.btnManageCustomer.TabIndex = 6;
            this.btnManageCustomer.Text = "Quản Lí Khách Hàng";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManagerCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnManageCustomer);
            this.panel2.Controls.Add(this.btnCategoryRoom);
            this.panel2.Controls.Add(this.btnBill);
            this.panel2.Controls.Add(this.btnExitMain);
            this.panel2.Controls.Add(this.btnBookRoom);
            this.panel2.Controls.Add(this.btnSearchRoom);
            this.panel2.Controls.Add(this.btnRevenue);
            this.panel2.Location = new System.Drawing.Point(662, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 401);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 372);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH SẠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManHinhChinh_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHotel)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbHotel;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnExitMain;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCategoryRoom;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

