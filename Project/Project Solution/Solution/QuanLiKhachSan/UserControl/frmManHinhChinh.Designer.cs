namespace QuanLiKhachSan.UserControl
{
    partial class frmManHinhChinh
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
            this.ptbHotel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbHotel
            // 
            this.ptbHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbHotel.Image = global::QuanLiKhachSan.Properties.Resources.HotelBeach;
            this.ptbHotel.Location = new System.Drawing.Point(0, 0);
            this.ptbHotel.Name = "ptbHotel";
            this.ptbHotel.Size = new System.Drawing.Size(1305, 630);
            this.ptbHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHotel.TabIndex = 0;
            this.ptbHotel.TabStop = false;
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbHotel);
            this.Name = "frmManHinhChinh";
            this.Size = new System.Drawing.Size(1305, 630);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHotel;
    }
}
