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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            int count = 0;
            if (ctr.Text.Length > 0)
            {
                for (int i = 0; i < ctr.Text.Length; i++)
                {
                    if (!char.IsLetter(ctr.Text[i]) && !char.IsWhiteSpace(ctr.Text[i]))
                    {
                        ++count;
                        errorProvider1.SetError(ctr, "Invalid input!");
                    }
                }
                if (count == 0)
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.SetError(ctr, "Field Required!");
                txtName.Focus();
            }
        }
        private void txtYear_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            int count = 0;
            if (ctr.Text.Length > 0)
            {
                for (int i = 0; i < ctr.Text.Length; i++)
                {
                    if (!char.IsDigit(ctr.Text[i]))
                    {
                        ++count;
                        errorProvider1.SetError(ctr, "Invalid input!");
                    }
                    
                }
                if (count == 0)
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.SetError(ctr, "Field Required!");
                txtYear.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtYear.Text)>0)
                {
                    int age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
                    string s = "My name is: " + txtName.Text + "\n" + "My age: " + age.ToString();
                    MessageBox.Show(s);
                }
                else
                {
                    MessageBox.Show("Year of Birth must be positive integer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Fields must be correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear();
            errorProvider1.Clear();
            txtName.Focus();
        }

        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
