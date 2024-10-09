using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_BTVN_Lap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HvaT.Text))
            {
                MessageBox.Show("Chưa nhập thông tin !!!");
                txt_HvaT.Focus();
                return;
            }
            else 
            {
                listBox1.Items.Add(txt_HvaT.Text);
                txt_HvaT.Clear();
                txt_HvaT.Focus();   
            }
        }

        private void btn_AsangB_Click(object sender, EventArgs e)
        {
            while(listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            
        }

        private void btn_BsangA_Click(object sender, EventArgs e)
        {
            while(listBox2.SelectedItems.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            
        }
        private void btn_AsangB1_Click(object sender, EventArgs e)
        {
            foreach( var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void btn_BsangA1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
        }
        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn chắc chắn kết thúc không!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            while(listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem); 
            }
        }
    }
}
