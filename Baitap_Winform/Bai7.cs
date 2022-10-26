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
    public partial class frmBai7 : Form
    {
        public frmBai7()
        {
            InitializeComponent();
        }

        private void txtText_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (String.IsNullOrEmpty(txtText.Text))
            {
                err.SetError(ctr,"Dữ liệu rỗng!");
                txtText.Focus();
            }
            else if (!char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                err.SetError(ctr, "Số không hợp lệ!");
                txtText.Focus();
            }
            else
            {
                err.Clear();
            }    
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cboText.Items.Clear();
            try
            {
                for (int i = 1; i <= Int32.Parse(txtText.Text); i++)
                {
                    cboText.Items.Add(i);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Số không hợp lệ!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void cboText_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst.Items.Clear();
            int n = Int32.Parse(cboText.SelectedItem.ToString());
            for (int i = 1; i <= n; i++)
            {
                if (n%i==0)
                {
                    lst.Items.Add(i);
                }
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count==0)
            {
                MessageBox.Show("Chưa chọn số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int tong = 0;
                int n = Int32.Parse(cboText.SelectedItem.ToString());
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                }                
                lst.Items.Clear();
                lst.Items.Add(tong);
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int dem = 0;
                int n = Int32.Parse(cboText.SelectedItem.ToString());
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0 && i%2==0)
                    {
                        ++dem;
                    }
                }
                lst.Items.Clear();
                lst.Items.Add(dem);
            }
        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int dem = 0;
                int n = Int32.Parse(cboText.SelectedItem.ToString());
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0 && ktSoNguyenTo(i)==true)
                    {
                        ++dem;
                    }
                }
                lst.Items.Clear();
                lst.Items.Add(dem);
            }
        }
        private bool ktSoNguyenTo(int n)
        {
            if (n==1)
            {
                return false;
            }    
            else
            {
                int dem = 0;
                for (int i=2;i<=n;++i)
                {
                    if (n%i==0)
                    {
                        ++dem;
                    } 
                }
                if (dem==1)
                {
                    return true;
                }    
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBai7_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (r==DialogResult.Cancel)
            {
                e.Cancel = true;
            }    
        }
    }
}
