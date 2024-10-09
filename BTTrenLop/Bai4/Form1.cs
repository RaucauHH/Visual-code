using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn chắc chắn thoát không!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btn_TT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKH.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng !!!");
                txt_TenKH.Focus();
                return;
            }
            else 
            {
                float total = 0;
                if (checkBox1.Checked) total += 100000;
                if (checkBox2.Checked) total += 1200000;
                if (checkBox3.Checked) total += 200000;
                total += (float) numericUpDown1.Value * 80000;
                txt_Total.Text = total.ToString();  
            }
        }
    }
}
