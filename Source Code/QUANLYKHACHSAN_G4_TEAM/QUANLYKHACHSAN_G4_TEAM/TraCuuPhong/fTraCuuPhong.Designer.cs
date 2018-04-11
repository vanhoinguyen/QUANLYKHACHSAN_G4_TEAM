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
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbStatusRoom = new System.Windows.Forms.ComboBox();
            this.cmbTypeRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSearchRoom = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Peru;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(505, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 38);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cmbStatusRoom
            // 
            this.cmbStatusRoom.FormattingEnabled = true;
            this.cmbStatusRoom.Location = new System.Drawing.Point(350, 58);
            this.cmbStatusRoom.Name = "cmbStatusRoom";
            this.cmbStatusRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusRoom.TabIndex = 18;
            // 
            // cmbTypeRoom
            // 
            this.cmbTypeRoom.FormattingEnabled = true;
            this.cmbTypeRoom.Location = new System.Drawing.Point(350, 25);
            this.cmbTypeRoom.Name = "cmbTypeRoom";
            this.cmbTypeRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeRoom.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tình Trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Phòng";
            // 
            // txtNameRoom
            // 
            this.txtNameRoom.Location = new System.Drawing.Point(78, 58);
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.Size = new System.Drawing.Size(158, 21);
            this.txtNameRoom.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Phòng";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.Location = new System.Drawing.Point(78, 26);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(158, 21);
            this.txtIdRoom.TabIndex = 12;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.BackColor = System.Drawing.Color.Peru;
            this.btnSearchRoom.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoom.ForeColor = System.Drawing.Color.Black;
            this.btnSearchRoom.Location = new System.Drawing.Point(505, 18);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(110, 38);
            this.btnSearchRoom.TabIndex = 19;
            this.btnSearchRoom.Text = "Tìm";
            this.btnSearchRoom.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSearchRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 306);
            this.panel1.TabIndex = 11;
            // 
            // dgvSearchRoom
            // 
            this.dgvSearchRoom.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSearchRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchRoom.Location = new System.Drawing.Point(0, 0);
            this.dgvSearchRoom.Name = "dgvSearchRoom";
            this.dgvSearchRoom.Size = new System.Drawing.Size(639, 306);
            this.dgvSearchRoom.TabIndex = 2;
            // 
            // fTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 412);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbStatusRoom);
            this.Controls.Add(this.cmbTypeRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdRoom);
            this.Controls.Add(this.btnSearchRoom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fTraCuuPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Phòng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbStatusRoom;
        private System.Windows.Forms.ComboBox cmbTypeRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSearchRoom;
    }
}