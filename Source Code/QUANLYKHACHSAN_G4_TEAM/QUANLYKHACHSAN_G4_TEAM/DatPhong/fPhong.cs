﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN_G4_TEAM.DatPhong
{
    public partial class fPhong : Form
    {
        public fPhong()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong.fDatPhong datphong = new DatPhong.fDatPhong();
            datphong.ShowDialog();
        }
    }
}
