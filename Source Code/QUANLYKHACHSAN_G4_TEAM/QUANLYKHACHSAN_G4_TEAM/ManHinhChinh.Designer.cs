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
            this.btnCategoryRoom = new System.Windows.Forms.Button();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategoryRoom
            // 
            this.btnCategoryRoom.Location = new System.Drawing.Point(67, 26);
            this.btnCategoryRoom.Name = "btnCategoryRoom";
            this.btnCategoryRoom.Size = new System.Drawing.Size(213, 48);
            this.btnCategoryRoom.TabIndex = 0;
            this.btnCategoryRoom.Text = "Danh Mục Phòng";
            this.btnCategoryRoom.UseVisualStyleBackColor = true;
            this.btnCategoryRoom.Click += new System.EventHandler(this.btnCategoryRoom_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(67, 80);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(213, 48);
            this.btnSearchRoom.TabIndex = 1;
            this.btnSearchRoom.Text = "Tra Cứu Phòng";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnListRoom_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(67, 134);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(213, 48);
            this.btnBookRoom.TabIndex = 2;
            this.btnBookRoom.Text = "Đặt Phòng";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(67, 188);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(213, 48);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Tính Tiền";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(67, 242);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(213, 48);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "Doanh Thu";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnExitMain
            // 
            this.btnExitMain.Location = new System.Drawing.Point(67, 296);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(213, 48);
            this.btnExitMain.TabIndex = 5;
            this.btnExitMain.Text = "Thoát";
            this.btnExitMain.UseVisualStyleBackColor = true;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 369);
            this.Controls.Add(this.btnExitMain);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.btnCategoryRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH SẠN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManHinhChinh_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategoryRoom;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnExitMain;
    }
}

