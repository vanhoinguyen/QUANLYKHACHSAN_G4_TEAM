namespace QUANLYKHACHSAN_G4_TEAM.DichVu
{
    partial class fSuaDichVu
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
            this.btnExitEditService = new System.Windows.Forms.Button();
            this.btnSaveEditService = new System.Windows.Forms.Button();
            this.txtEditPriceService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditUnitService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditNameService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitEditService
            // 
            this.btnExitEditService.BackColor = System.Drawing.Color.Black;
            this.btnExitEditService.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitEditService.ForeColor = System.Drawing.Color.Red;
            this.btnExitEditService.Location = new System.Drawing.Point(225, 178);
            this.btnExitEditService.Name = "btnExitEditService";
            this.btnExitEditService.Size = new System.Drawing.Size(74, 47);
            this.btnExitEditService.TabIndex = 19;
            this.btnExitEditService.Text = "Hủy";
            this.btnExitEditService.UseVisualStyleBackColor = false;
            this.btnExitEditService.Click += new System.EventHandler(this.btnExitEditService_Click);
            // 
            // btnSaveEditService
            // 
            this.btnSaveEditService.BackColor = System.Drawing.Color.Black;
            this.btnSaveEditService.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditService.ForeColor = System.Drawing.Color.Red;
            this.btnSaveEditService.Location = new System.Drawing.Point(111, 178);
            this.btnSaveEditService.Name = "btnSaveEditService";
            this.btnSaveEditService.Size = new System.Drawing.Size(74, 47);
            this.btnSaveEditService.TabIndex = 18;
            this.btnSaveEditService.Text = "Lưu";
            this.btnSaveEditService.UseVisualStyleBackColor = false;
            // 
            // txtEditPriceService
            // 
            this.txtEditPriceService.Location = new System.Drawing.Point(111, 129);
            this.txtEditPriceService.Name = "txtEditPriceService";
            this.txtEditPriceService.Size = new System.Drawing.Size(188, 20);
            this.txtEditPriceService.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Đơn Giá";
            // 
            // txtEditUnitService
            // 
            this.txtEditUnitService.Location = new System.Drawing.Point(111, 77);
            this.txtEditUnitService.Name = "txtEditUnitService";
            this.txtEditUnitService.Size = new System.Drawing.Size(188, 20);
            this.txtEditUnitService.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đơn Vị Tính";
            // 
            // txtEditNameService
            // 
            this.txtEditNameService.Location = new System.Drawing.Point(111, 29);
            this.txtEditNameService.Name = "txtEditNameService";
            this.txtEditNameService.Size = new System.Drawing.Size(188, 20);
            this.txtEditNameService.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Dịch Vụ";
            // 
            // fSuaDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(317, 255);
            this.Controls.Add(this.btnExitEditService);
            this.Controls.Add(this.btnSaveEditService);
            this.Controls.Add(this.txtEditPriceService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEditUnitService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditNameService);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fSuaDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh Sửa Dịch Vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitEditService;
        private System.Windows.Forms.Button btnSaveEditService;
        private System.Windows.Forms.TextBox txtEditPriceService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditUnitService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditNameService;
        private System.Windows.Forms.Label label1;
    }
}