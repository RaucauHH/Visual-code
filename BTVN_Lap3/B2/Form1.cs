using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rtxt_HauTo.Visible = false;
            btn_Chuyen.Enabled = false;
        } 

        private void btn_Chuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxt_TrungTo.Text))
            {
                MessageBox.Show("Vui lòng nhập biểu thức trung tố.");
                return;
            }
            else { 
                // Vô hiệu hóa richTextBox nhập biểu thức trung tố
                rtxt_TrungTo.Enabled = false;

                // Thực hiện chuyển đổi từ trung tố sang hậu tố
                string bieuThucTrungTo = rtxt_TrungTo.Text;
                string bieuThucHauTo = ChuyenTrungToSangHauTo(bieuThucTrungTo); // Hàm chuyển đổi

                // Hiển thị kết quả hậu tố
                rtxt_HauTo.Text = bieuThucHauTo;
                rtxt_HauTo.Visible = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn chắc chắn thoát không!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

       

        // Hàm chuyển biểu thức trung tố sang hậu tố (ví dụ đơn giản)
        private string ChuyenTrungToSangHauTo(string trungTo)
        {
            // Logic chuyển đổi biểu thức trung tố sang hậu tố có thể phức tạp hơn
            // Đây chỉ là ví dụ cho phép tính cơ bản với đủ ngoặc
            Stack<char> stack = new Stack<char>();
            string hauTo = "";

            foreach (char c in trungTo)
            {
                if (char.IsDigit(c))
                {
                    hauTo += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        hauTo += stack.Pop();
                    }
                    stack.Pop(); // Loại bỏ '('
                }
                else if (IsOperator(c))
                {
                    while (stack.Count > 0 && Precedence(c) <= Precedence(stack.Peek()))
                    {
                        hauTo += stack.Pop();
                    }
                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                hauTo += stack.Pop();
            }

            return hauTo;
        }

        // Kiểm tra xem ký tự có phải là toán tử hay không
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // Xác định độ ưu tiên của toán tử
        private int Precedence(char c)
        {
            if (c == '+' || c == '-')
                return 1;
            if (c == '*' || c == '/')
                return 2;
            return 0;
        }

        private void rtxt_HauTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxt_TrungTo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtxt_TrungTo.Text))
            {
                btn_Chuyen.Enabled = true;
            }
            else
            {
                btn_Chuyen.Enabled = false;
            }
        }
    }
}
