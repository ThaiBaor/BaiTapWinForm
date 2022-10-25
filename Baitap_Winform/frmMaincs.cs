using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baitap_Winform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuBai1_Click(object sender, EventArgs e)
        {
            frmBai1 frm = new frmBai1();
            frm.ShowDialog();
        }

        private void mnuBai2_Click(object sender, EventArgs e)
        {
            frmBai2 frm = new frmBai2();
            frm.ShowDialog();
        }

        private void mnuBai3_Click(object sender, EventArgs e)
        {
            frmBai3 frm = new frmBai3();
            frm.ShowDialog();
        }

        private void mnuBai4_Click(object sender, EventArgs e)
        {
            frmBai4 frm = new frmBai4();
            frm.ShowDialog();
        }

        private void mnuBai5_Click(object sender, EventArgs e)
        {
            frmBai5 frm = new frmBai5();
            frm.ShowDialog();
            this.Close();
        }
    }
}
