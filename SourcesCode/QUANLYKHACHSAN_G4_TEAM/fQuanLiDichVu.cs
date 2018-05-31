﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace QUANLYKHACHSAN_G4_TEAM.QuanLiDichVu
{
    public partial class fQuanLiDichVu : DevExpress.XtraEditors.XtraForm
    {
        public fQuanLiDichVu()
        {
            InitializeComponent();
        }

        /*private void ThietLapTextbox(bool flag)
        {
            cmbLoaiPhong.Enabled = flag;
            txtTinhTrang.Enabled = flag;
            txtGhiChu.Enabled = flag;
        }*/

        /*private void ThietLapButton(bool flag)
        {
            btnThem.Enabled = !flag;
            btnSua.Enabled = !flag;
            btnXoa.Enabled = !flag;

            btnLuu.Enabled = flag;
        }*/
        private void LamSachDL()
        {
            txtNameService.Text = "";
            txtUnitService.Text = "";
            txtPriceService.Text = "";
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                LamSachDL();
                
                btnThem.Text = "Ngừng";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                //ThietLapTextbox(true);
                gridControl1.Enabled = false;
            }
            else
            {
                btnThem.Text = "Thêm";
                fQuanLiDichVu_Load(sender, e);
                //KhoiTaoLai();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                gridControl1.Enabled = true;
                

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DichVuDTO infor = LayThongTinDichVu();
            infor.MaDichVu = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDichVu"]).ToString());

            DialogResult result = (MessageBox.Show("Bạn có muốn xóa dịch vụ " + txtNameService.Text + " không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (result == DialogResult.Yes)
            {
                if (DichVuBUS.XoaDichVu(infor))
                {
                    MessageBox.Show("Bạn đã xóa dịch vụ " + txtNameService.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fQuanLiDichVu_Load(sender, e);
                    //KhoiTaoLai();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
                if (btnSua.Text == "Sửa")
                {
                    
                    btnSua.Text = "Ngừng";
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = true;                                      
                    gridControl1.Enabled = false;
                }
                else
                {
                    btnSua.Text = "Sửa";
                    fQuanLiDichVu_Load(sender, e);
                //KhoiTaoLai();
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    gridControl1.Enabled = true;
                }
            
        }
        private DichVuDTO LayThongTinDichVu()
        {
            DichVuDTO infor = new DichVuDTO();

           
            infor.TenDichVu = txtNameService.Text;
            infor.DonViTinh = txtUnitService.Text;
            infor.DonGia = Convert.ToDecimal( txtPriceService.Text);
            return infor;
        }
        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DichVuDTO infor = LayThongTinDichVu();
            
            if (btnThem.Text == "Ngừng")
            {
                if (DichVuBUS.ThemDichVu(infor))
                {
                    MessageBox.Show("Bạn đã thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fQuanLiDichVu_Load(sender, e);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    gridControl1.Enabled = true;
                    btnThem.Text = "Thêm";
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else if (btnSua.Text == "Ngừng")
            {
                infor.MaDichVu = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["MaDichVu"]).ToString());
                if (DichVuBUS.SuaThongTinDichVu(infor))
                {
                    MessageBox.Show("Bạn đã sửa thông tin dịch vụ " + txtNameService.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fQuanLiDichVu_Load(sender, e);
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    gridControl1.Enabled = true;
                    btnSua.Text = "Sửa";
                }
                else
                    MessageBox.Show("Lỗi");
            }
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            fOderDichVu oder = new fOderDichVu();
            oder.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {    
                txtNameService.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["TenDichVu"]).ToString();
                txtUnitService.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonViTinh"]).ToString();
                txtPriceService.Text = string.Format("{0:0,0}", gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["DonGia"]));
                

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fQuanLiDichVu_Load(object sender, EventArgs e)
        {
            List<DichVuDTO> lstt = new List<DichVuDTO>();
            lstt = DichVuBUS.LoadDanhSach();
            for(int i =0;i<gridView1.RowCount;i++)
            {
                lstt[i].DonGia = Convert.ToDecimal(string.Format("{0:0,0}", lstt[i].DonGia));
            }
            gridControl1.DataSource = lstt;
        }

        
    }
}