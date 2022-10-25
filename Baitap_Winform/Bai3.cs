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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void txtA_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (String.IsNullOrEmpty(ctr.Text))
            {
                errorProvider.SetError(ctr, "Input is null!");
                txtA.Focus();               
            }
            else if (!char.IsDigit(ctr.Text,ctr.Text.Length - 1))
            {
                this.errorProvider.SetError(ctr, "This is not invalid number");
                txtA.Focus();
            }
             else
            {
                this.errorProvider.Clear();
            }
        }

        private void txtB_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (String.IsNullOrEmpty(ctr.Text))
            {
                errorProvider.SetError(ctr, "Input is null!");
                txtB.Focus();
            }
            else if (!char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider.SetError(ctr, "This is not invalid number");
                txtB.Focus();
            }
            else
            {
                this.errorProvider.Clear();
            }
        }

        private void rbtnPlus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int result = Int32.Parse(txtA.Text) + Int32.Parse(txtB.Text);
                txtR.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Incorrect", "Invalid input");
            }
        }

        private void rbtnMinus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int result = Int32.Parse(txtA.Text) - Int32.Parse(txtB.Text);
                txtR.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Incorrect", "Invalid input");
            }
        }

        private void rbtnMultiple_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int result = Int32.Parse(txtA.Text) * Int32.Parse(txtB.Text);
                txtR.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Incorrect", "Invalid input");
            }
        }

        private void rbtnDivide_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double result = (double)Int32.Parse(txtA.Text) / Int32.Parse(txtB.Text);
                txtR.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Incorrect", "Invalid input");
            }
        }

        private void frmBai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
