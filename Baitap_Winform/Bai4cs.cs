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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            lblTen.Text = txtTen.Text;
        }

        private void rdoDo_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Red;
        }

        private void rdoXanhDuong_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Blue;
        }

        private void rdoXanhLa_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Green;
        }

        private void rdoDen_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.ForeColor = Color.Purple;
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.Font = new Font(lblTen.Font.Name, lblTen.Font.Size, lblTen.Font.Style ^ FontStyle.Bold);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.Font = new Font(lblTen.Font.Name, lblTen.Font.Size, lblTen.Font.Style ^ FontStyle.Underline);
        }

        private void chkNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblTen.Font = new Font(lblTen.Font.Name, lblTen.Font.Size, lblTen.Font.Style ^ FontStyle.Italic);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            chkGachChan.Checked = false;
            chkInDam.Checked = false;
            chkNghieng.Checked = false;
            rdoDo.Checked = false;
            rdoTim.Checked = false;
            rdoXanhDuong.Checked = false;
            rdoXanhLa.Checked = false;
            lblTen.ForeColor = Color.Black;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
