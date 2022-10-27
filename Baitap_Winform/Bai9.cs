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
    public partial class frmBai9 : Form
    {
        public frmBai9()
        {
            InitializeComponent();
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboKhuVuc.SelectedIndex)
            {
                case 0:
                    txtDinhMuc.Text = "50";
                    break;
                case 1:
                    txtDinhMuc.Text = "100";
                    break;
                default:
                    txtDinhMuc.Text = "150";
                    break;
            }
        }

        private void txtSoCu_Validated(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (string.IsNullOrEmpty(ctr.Text) || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                err.SetError(ctr, "Dữ liệu trỗng hoặc không phải số!");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtSoMoi_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (string.IsNullOrEmpty(ctr.Text) || !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                err.SetError(ctr, "Dữ liệu trỗng hoặc không phải số!");
            }
            else
            {
                err.Clear();
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtSoMoi.Text) < double.Parse(txtSoCu.Text))
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double thanhTien = 0;
                double dienTieuThu = double.Parse(txtSoMoi.Text) - double.Parse(txtSoCu.Text);
                txtTieuThu.Text = dienTieuThu.ToString();
                if (dienTieuThu <= Int32.Parse(txtDinhMuc.Text))
                {
                    thanhTien = dienTieuThu * 500;
                }
                else
                {
                    thanhTien = Int32.Parse(txtDinhMuc.Text) * 500 + (dienTieuThu - Int32.Parse(txtDinhMuc.Text)) * 1000;
                }
                txtThanhTien.Text = thanhTien.ToString();
                ListViewItem listViewItem = new ListViewItem(txtTenKH.Text);
                listViewItem.SubItems.Add(cboKhuVuc.SelectedItem.ToString());
                listViewItem.SubItems.Add(txtDinhMuc.Text);
                listViewItem.SubItems.Add(txtTieuThu.Text);
                listViewItem.SubItems.Add(txtThanhTien.Text);
                lstv.Items.Add(listViewItem);
                double tong = 0;
                for (int i = 0; i < lstv.Items.Count; i++)
                {
                    txtTong.Text = lstv.Items[i].SubItems[3].ToString();
                    tong += double.Parse(lstv.Items[i].SubItems[4].Text.ToString());
                }
                txtTong.Text = tong.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            cboKhuVuc.SelectedItem = null;
            txtTenKH.Clear();
            txtDinhMuc.Clear();
            txtSoCu.Clear();
            txtSoMoi.Clear();
            txtTieuThu.Clear();
            txtThanhTien.Clear();
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = lstv.SelectedItems.Count - 1; i >= 0; i--)
            {
                if (i == lstv.SelectedItems.Count - 1)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.No)
                    {
                        return;
                    }
                }
                lstv.Items.Remove(lstv.SelectedItems[i]);
            }
            double tong = 0;
            for (int i = 0; i < lstv.Items.Count; i++)
            {
                txtTong.Text = lstv.Items[i].SubItems[3].ToString();
                tong += double.Parse(lstv.Items[i].SubItems[4].Text.ToString());
            }
            txtTong.Text = tong.ToString();
        }
    }
}
