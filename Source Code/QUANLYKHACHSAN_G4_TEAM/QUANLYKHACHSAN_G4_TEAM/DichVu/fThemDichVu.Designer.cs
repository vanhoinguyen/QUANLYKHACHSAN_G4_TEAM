namespace QUANLYKHACHSAN_G4_TEAM.DichVu
{
    partial class fThemDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewNameService = new System.Windows.Forms.TextBox();
            this.txtNewUnitService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPriceService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitNewService = new System.Windows.Forms.Button();
            this.btnSaveNewService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // txtNewNameService
            // 
            this.txtNewNameService.Location = new System.Drawing.Point(105, 31);
            this.txtNewNameService.Name = "txtNewNameService";
            this.txtNewNameService.Size = new System.Drawing.Size(188, 20);
            this.txtNewNameService.TabIndex = 2;
            // 
            // txtNewUnitService
            // 
            this.txtNewUnitService.Location = new System.Drawing.Point(105, 79);
            this.txtNewUnitService.Name = "txtNewUnitService";
            this.txtNewUnitService.Size = new System.Drawing.Size(188, 20);
            this.txtNewUnitService.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn Vị Tính";
            // 
            // txtNewPriceService
            // 
            this.txtNewPriceService.Location = new System.Drawing.Point(105, 131);
            this.txtNewPriceService.Name = "txtNewPriceService";
            this.txtNewPriceService.Size = new System.Drawing.Size(188, 20);
            this.txtNewPriceService.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn Giá";
            // 
            // btnExitNewService
            // 
            this.btnExitNewService.BackColor = System.Drawing.Color.Black;
            this.btnExitNewService.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitNewService.ForeColor = System.Drawing.Color.Red;
            this.btnExitNewService.Location = new System.Drawing.Point(219, 180);
            this.btnExitNewService.Name = "btnExitNewService";
            this.btnExitNewService.Size = new System.Drawing.Size(74, 47);
            this.btnExitNewService.TabIndex = 11;
            this.btnExitNewService.Text = "Hủy";
            this.btnExitNewService.UseVisualStyleBackColor = false;
            this.btnExitNewService.Click += new System.EventHandler(this.btnExitNewService_Click);
            // 
            // btnSaveNewService
            // 
            this.btnSaveNewService.BackColor = System.Drawing.Color.Black;
            this.btnSaveNewService.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewService.ForeColor = System.Drawing.Color.Red;
            this.btnSaveNewService.Location = new System.Drawing.Point(105, 180);
            this.btnSaveNewService.Name = "btnSaveNewService";
            this.btnSaveNewService.Size = new System.Drawing.Size(74, 47);
            this.btnSaveNewService.TabIndex = 10;
            this.btnSaveNewService.Text = "Lưu";
            this.btnSaveNewService.UseVisualStyleBackColor = false;
            // 
            // fThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(317, 255);
            this.Controls.Add(this.btnExitNewService);
            this.Controls.Add(this.btnSaveNewService);
            this.Controls.Add(this.txtNewPriceService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewUnitService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewNameService);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fThemDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Dịch Vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewNameService;
        private System.Windows.Forms.TextBox txtNewUnitService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPriceService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExitNewService;
        private System.Windows.Forms.Button btnSaveNewService;
    }
}