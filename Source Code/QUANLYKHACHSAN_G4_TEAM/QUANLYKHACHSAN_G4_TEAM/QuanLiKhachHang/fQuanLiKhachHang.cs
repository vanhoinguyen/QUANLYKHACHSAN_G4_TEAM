﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN_G4_TEAM.QuanLiKhachHang
{
    public partial class fQuanLiKhachHang : Form
    {
        public fQuanLiKhachHang()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang.fThemKhachHang addcustomer = new fThemKhachHang();
            addcustomer.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            QuanLiKhachHang.fSuaThongTinKhachHang editcustomer = new fSuaThongTinKhachHang();
            editcustomer.Show();
        }
    }
}
