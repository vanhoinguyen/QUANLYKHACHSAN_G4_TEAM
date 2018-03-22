namespace QUANLYKHACHSAN_G4_TEAM.DichVu
{
    partial class fDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnExitService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvListService = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditService);
            this.panel1.Controls.Add(this.btnExitService);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.btnRemoveService);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 68);
            this.panel1.TabIndex = 2;
            // 
            // btnEditService
            // 
            this.btnEditService.BackColor = System.Drawing.Color.Black;
            this.btnEditService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditService.ForeColor = System.Drawing.Color.Red;
            this.btnEditService.Location = new System.Drawing.Point(285, 10);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(106, 49);
            this.btnEditService.TabIndex = 2;
            this.btnEditService.Text = "Sửa ";
            this.btnEditService.UseVisualStyleBackColor = false;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnExitService
            // 
            this.btnExitService.BackColor = System.Drawing.Color.Black;
            this.btnExitService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitService.ForeColor = System.Drawing.Color.Red;
            this.btnExitService.Location = new System.Drawing.Point(421, 10);
            this.btnExitService.Name = "btnExitService";
            this.btnExitService.Size = new System.Drawing.Size(106, 49);
            this.btnExitService.TabIndex = 3;
            this.btnExitService.Text = "Thoát";
            this.btnExitService.UseVisualStyleBackColor = false;
            this.btnExitService.Click += new System.EventHandler(this.btnExitService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.Black;
            this.btnAddService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.Red;
            this.btnAddService.Location = new System.Drawing.Point(3, 10);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(106, 49);
            this.btnAddService.TabIndex = 0;
            this.btnAddService.Text = "Thêm ";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.BackColor = System.Drawing.Color.Black;
            this.btnRemoveService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveService.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveService.Location = new System.Drawing.Point(148, 10);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(106, 49);
            this.btnRemoveService.TabIndex = 1;
            this.btnRemoveService.Text = "Xóa ";
            this.btnRemoveService.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListService);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 313);
            this.panel2.TabIndex = 3;
            // 
            // dgvListService
            // 
            this.dgvListService.BackgroundColor = System.Drawing.Color.White;
            this.dgvListService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListService.Location = new System.Drawing.Point(0, 0);
            this.dgvListService.Name = "dgvListService";
            this.dgvListService.Size = new System.Drawing.Size(639, 313);
            this.dgvListService.TabIndex = 1;
            // 
            // fDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(639, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "fDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch Vụ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnExitService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListService;
    }
}