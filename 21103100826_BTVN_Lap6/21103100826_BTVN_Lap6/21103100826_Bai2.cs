using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21103100826_BTVN_Lap6
{
    public partial class _21103100826_Bai2 : Form
    {
        public _21103100826_Bai2()
        {
            InitializeComponent();
        }
        
        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txt_Nhap.Text.Trim();

            if (string.IsNullOrEmpty(tenSinhVien))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_Nhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_Nhom.SelectedItem.ToString() == "Nhóm 1")
            {
                listBox1.Items.Add(tenSinhVien);
            }
            else if (cb_Nhom.SelectedItem.ToString() == "Nhóm 2")
            {
                listBox2.Items.Add(tenSinhVien);
            }

            txt_Nhap.Clear();
            CapNhapSV();
        }
        
        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQua2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems.Cast<string>().ToList())
            {
                listBox2.Items.Add(item);
                listBox1.Items.Remove(item);
            }
            CapNhapSV();
        }

        private void btnQua1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.SelectedItems.Cast<string>().ToList())
            {
                listBox1.Items.Add(item);
                listBox2.Items.Remove(item);
            }
            CapNhapSV();
        }

        private void btnChuyen2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items.Cast<string>().ToList())
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
            CapNhapSV();
        }

        private void btnChuyen1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items.Cast<string>().ToList())
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
            CapNhapSV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                XoaLB(listBox1);
            }
            else if(listBox2.SelectedItems.Count > 0)
            {
                XoaLB(listBox2);
            }
            CapNhapSV();
        }

        private void CapNhapSV()
        {
            lbl_Tong1.Text = $"Tổng số: {listBox1.Items.Count}";
            lbl_Tong2.Text = $"Tổng số: {listBox2.Items.Count}";
        }
        
        private void XoaLB(ListBox listBox)
        {
            while (listBox.SelectedItems.Count > 0)
            {
                listBox.Items.Remove(listBox.SelectedItems[0]);
            }
            CapNhapSV();
        }
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txt_Nhap.Text.Trim();

            if (string.IsNullOrEmpty(tenSinhVien))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_Nhom.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cb_Nhom.SelectedItem.ToString() == "Nhóm 1")
            {
                listBox1.Items.Add(tenSinhVien);
            }
            else if (cb_Nhom.SelectedItem.ToString() == "Nhóm 2")
            {
                listBox2.Items.Add(tenSinhVien);
            }

            txt_Nhap.Clear();
            CapNhapSV();
        }

        private void btn_ThoatCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_21103100826_Click(object sender, EventArgs e)
        {

        }
    }
}
