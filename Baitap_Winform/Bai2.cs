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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private void txtB_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            int count = 0;
            if (ctr.Text.Length > 0)
            {
                if (ctr.Text[0] != '-' && !char.IsDigit(ctr.Text[0]))
                {
                    errorProvider1.SetError(ctr, "Phai nhap so nguyen!");
                    return;
                }
                for (int i = 1; i < ctr.Text.Length; i++)
                {
                    if (!char.IsDigit(ctr.Text[i]))
                    {
                        ++count;
                        errorProvider1.SetError(ctr, "Phai nhap so nguyen!");
                    }
                }
                if (count == 0)
                {
                    errorProvider1.Clear();
                }
            }           
        }

        private void txtA_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            int count = 0;
            if (ctr.Text.Length>0)
            {
                if (ctr.Text[0]!='-' && !char.IsDigit(ctr.Text[0]))
                {
                    errorProvider1.SetError(ctr, "Phai nhap so nguyen!");
                    return;
                }
                for (int i=1;i<ctr.Text.Length;i++)
                {
                    if (!char.IsDigit(ctr.Text[i]))
                    {
                        ++count;
                        errorProvider1.SetError(ctr,"Phai nhap so nguyen!");
                    }
                }
                if (count==0)
                {
                    errorProvider1.Clear();
                }
            }           
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double kq =(double)Int32.Parse(txtB.Text)*(-1) / Int32.Parse(txtA.Text);
                txtX.Text = kq.ToString();
            }
            catch
            {
                MessageBox.Show("Du lieu khong hop le", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtX.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
