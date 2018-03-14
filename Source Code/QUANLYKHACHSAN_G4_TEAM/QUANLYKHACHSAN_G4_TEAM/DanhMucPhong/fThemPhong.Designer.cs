namespace QUANLYKHACHSAN_G4_TEAM.DanhMucPhong
{
    partial class fThemPhong
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
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.txtNameRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeRoom = new System.Windows.Forms.ComboBox();
            this.btnExitRoom = new System.Windows.Forms.Button();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(97, 191);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(90, 41);
            this.btnAddRoom.TabIndex = 14;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Location = new System.Drawing.Point(97, 154);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(204, 20);
            this.txtPriceRoom.TabIndex = 13;
            // 
            // txtNameRoom
            // 
            this.txtNameRoom.Location = new System.Drawing.Point(97, 57);
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.Size = new System.Drawing.Size(204, 20);
            this.txtNameRoom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loại Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên Phòng";
            // 
            // cmbTypeRoom
            // 
            this.cmbTypeRoom.FormattingEnabled = true;
            this.cmbTypeRoom.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTypeRoom.Location = new System.Drawing.Point(97, 104);
            this.cmbTypeRoom.Name = "cmbTypeRoom";
            this.cmbTypeRoom.Size = new System.Drawing.Size(204, 21);
            this.cmbTypeRoom.TabIndex = 15;
            // 
            // btnExitRoom
            // 
            this.btnExitRoom.Location = new System.Drawing.Point(211, 191);
            this.btnExitRoom.Name = "btnExitRoom";
            this.btnExitRoom.Size = new System.Drawing.Size(90, 41);
            this.btnExitRoom.TabIndex = 16;
            this.btnExitRoom.Text = "Thoát";
            this.btnExitRoom.UseVisualStyleBackColor = true;
            this.btnExitRoom.Click += new System.EventHandler(this.btnExitRoom_Click_1);
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.Location = new System.Drawing.Point(97, 12);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(204, 20);
            this.txtIdRoom.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã Phòng";
            // 
            // fThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 260);
            this.Controls.Add(this.txtIdRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExitRoom);
            this.Controls.Add(this.cmbTypeRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.txtNameRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fThemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.TextBox txtNameRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeRoom;
        private System.Windows.Forms.Button btnExitRoom;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label4;
    }
}