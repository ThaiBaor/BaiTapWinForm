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
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
        }

        private void frmBai6_Load(object sender, EventArgs e)
        {
            rdoVietNam.Checked = true;
        }

        private void rdoVietNam_CheckedChanged(object sender, EventArgs e)
        {
            pic.Image = Properties.Resources.coVietNam;
        }

        private void rdoUSA_CheckedChanged(object sender, EventArgs e)
        {
            pic.Image = Properties.Resources.coUSAjpg;
        }

        private void rdoThai_CheckedChanged(object sender, EventArgs e)
        {
            pic.Image = Properties.Resources.coThai;
        }

        private void rdoSing_CheckedChanged(object sender, EventArgs e)
        {
            pic.Image = Properties.Resources.coSing;
        }

        private void frmBai6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }
    }
}
