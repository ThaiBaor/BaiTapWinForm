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
    public partial class frmBai8 : Form
    {
        public frmBai8()
        {
            InitializeComponent();
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (string.IsNullOrEmpty(ctr.Text) || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                err.SetError(ctr, "Dữ liệu không phải là số");
            }
            else
            {
                err.Clear();
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text) || !char.IsDigit(txt.Text, txt.Text.Length - 1))
            {
                MessageBox.Show("Dữ liệu không phải là số","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txt.Focus();
            }
            else
            {
                lst.Items.Add(txt.Text);
                txt.Clear();
                txt.Focus();
            }           
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i=0;i<lst.Items.Count;i++)
            {
                tong += Int32.Parse(lst.Items[i].ToString());
            }
            MessageBox.Show($"Tổng tất cả phần tử trong list box: {tong}", "Kết quả");
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst.Items.Count>=2)
                {
                    MessageBox.Show($"Đã xóa phần tử {lst.Items[0]} và {lst.Items[lst.Items.Count - 1]}");
                    lst.Items.RemoveAt(lst.Items.Count - 1);
                    lst.Items.RemoveAt(0);
                }
                else if (lst.Items.Count == 1)
                {
                    MessageBox.Show($"Đã xóa phần tử {lst.Items[0]}");
                    lst.Items.RemoveAt(0);
                }    
            }
            catch(Exception)
            {
                MessageBox.Show("Không có phần tử nào trong list box", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            try
            {
                lst.Items.Remove(lst.SelectedItem);
            }
            catch(Exception)
            {
                MessageBox.Show("Chưa chọn phần tử nào trong list box", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Items.Count; i++)
            {
               lst.Items[i] = 2 + Int32.Parse(lst.Items[i].ToString());
            }
            MessageBox.Show($"Đã tăng tất cả phần tử trong list box lên 2. ", "Kết quả");
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Items.Count; i++)
            {
                lst.Items[i] = Int32.Parse(lst.Items[i].ToString()) * Int32.Parse(lst.Items[i].ToString());
            }
            MessageBox.Show($"Đã bình phương tất cả phần tử trong list box. ", "Kết quả");
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            lst.SelectedItems.Clear();
            for (int i = 0; i < lst.Items.Count; i++)
            {
                if (Int32.Parse(lst.Items[i].ToString())% 2==0)
                {
                    lst.SelectedItems.Add(lst.Items[i]);
                }
            }
        }

        private void btnSoLe_Click(object sender, EventArgs e)
        {
            lst.SelectedItems.Clear();
            for (int i = 0; i < lst.Items.Count; i++)
            {
                if (Int32.Parse(lst.Items[i].ToString()) % 2 != 0)
                {
                    lst.SelectedItems.Add(lst.Items[i]);
                }
            }
        }

        private void frmBai8_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r==DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
