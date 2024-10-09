using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_KQ.Visible = false;
        }
        // Hàm tính tổng các chữ số của n
        private int TinhTongChuSo(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10; // Lấy chữ số cuối cùng của n
                n /= 10; // Loại bỏ chữ số cuối cùng
            }
            return tong;
        }

        // Hàm kiểm tra số nguyên tố
        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false; // Số nguyên tố phải lớn hơn 1
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false; // Nếu n chia hết cho i thì không phải nguyên tố
            }
            return true;
        }
        private void btn_TinhTong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_n.Text))
            {
                MessageBox.Show("Vui lòng nhập số n.");
                return;
            }

            if (!int.TryParse(txt_n.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương.");
                return;
            }

            int tongChuSo = TinhTongChuSo(n);
            txt_KQ.Text = "Tổng các chữ số của " + n + " là: " + tongChuSo;
            txt_KQ.Visible = true; // Hiển thị kết quả
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_n.Text))
            {
                MessageBox.Show("Vui lòng nhập số n.");
                return;
            }
            

            if (!int.TryParse(txt_n.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương.");
                return;
            }

            bool laNguyenTo = KiemTraNguyenTo(n);
            if (laNguyenTo)
            {
                MessageBox.Show(n + " là số nguyên tố.");
            }
            else
            {
                MessageBox.Show(n + " không phải là số nguyên tố.");
            }
        }
    }
}
