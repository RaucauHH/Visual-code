using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Hoten.Text))
            {
                MessageBox.Show("Chưa nhập thông tin !!!");
                txt_Hoten.Focus();
                return;
            }
            else
            {
                listBox1.Items.Add(txt_Hoten.Text);
                txt_Songuoi.Text = listBox1.Items.Count.ToString();
                txt_Hoten.Clear();
                txt_Hoten.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i >= 0)
            {
                txt_Hoten.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void btn_Xoachon_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("Chưa chọn thông tin cần xóa");
                return;
            }
            else 
            {
                listBox1.Items.RemoveAt(i);
                txt_Hoten.Clear();
                txt_Songuoi.Text = listBox1.Items.Count.ToString();
            }
        }
        private void btn_Xoabandau_Click(object sender, EventArgs e)
            {
                if(listBox1.Items.Count > 0)
                {
                    if (listBox1.SelectedIndex == 0)
                        txt_Hoten.Clear();
                        txt_Songuoi.Text = listBox1.Items.Count.ToString();
                        listBox1.Items.RemoveAt(0);
                }
            }
        private void btn_Xoatatca_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_Songuoi.Text = listBox1.Items.Count.ToString();
            txt_Hoten.Clear();
        }       

        private void btn_Xoacuoi_Click(object sender, EventArgs e)
        {
            
            if (listBox1.Items.Count > 0)
            {
                int i = listBox1.Items.Count;

                if (listBox1.SelectedIndex == i-1)
                txt_Hoten.Clear();
                txt_Songuoi.Text = listBox1.Items.Count.ToString();
                listBox1.Items.RemoveAt(i-1);
            }
        }
    }
}
