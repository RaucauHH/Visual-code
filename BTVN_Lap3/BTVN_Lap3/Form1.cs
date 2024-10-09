using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Lap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Giai.Enabled = false;
            txt_KetQua.Visible = false;
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            double a, b;
            bool isAValid = double.TryParse(txt_a.Text, out a);
            bool isBValid = double.TryParse(txt_b.Text, out b);

            if (txt_a.Text == "" || txt_b.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.");
            }
            else if (!isAValid || !isBValid)
            {
                MessageBox.Show("Dữ liệu nhập vào phải là số thực.");
            }
            else
            {
                MessageBox.Show("Dữ liệu đã hợp lệ.");
                btn_Giai.Enabled = true;
                btn_KiemTra.Enabled = false;
            }
        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_a.Text);
            double b = double.Parse(txt_b.Text);
            string ketQua = "";

            if (a == 0)
            {
                if (b < 0)
                    ketQua = "Bất phương trình đúng với mọi x.";
                else
                    ketQua = "Bất phương trình vô nghiệm.";
            }
            else
            {
                double nghiem = -b / a;
                ketQua = $"Bất phương trình có nghiệm x < {nghiem}.";
            }

            txt_KetQua.Text = ketQua;
            txt_KetQua.Visible = true;
        }
    }
}

