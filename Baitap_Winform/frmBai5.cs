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
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void rdoTNR_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Times New Roman", txtText.Font.Size, txtText.Font.Style);
        }

        private void rdoAr_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Arial", txtText.Font.Size, txtText.Font.Style);
        }

        private void rdoTahoma_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Tahoma", txtText.Font.Size, txtText.Font.Style);
        }

        private void rdoCN_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Courier New", txtText.Font.Size, txtText.Font.Style);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }
    }
}
