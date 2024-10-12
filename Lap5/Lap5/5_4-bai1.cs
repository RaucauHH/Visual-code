using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox_Di.Items.Add("Hà Nội");
            listBox_Di.Items.Add("TPHCM");
            listBox_Di.Items.Add("Hải Phòng");
            listBox_Ve.Items.Add("Hạ Long");
            listBox_Ve.Items.Add("Vũng Tàu");
            listBox_Ve.Items.Add("Đà Nẵng");
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {            
            string hoten = txt_KH.Text.Trim();
            string diachi = txt_DC.Text.Trim(); 
            DateTime ngaysinh = dtp_Ngaysinh.Value.Date;
            if (hoten.Equals(""))
            {
                MessageBox.Show("Hãy nhập tên khách hàng");
                txt_KH.Focus();
                return;
            }
            if (diachi.Equals(""))
            {
                MessageBox.Show("Hãy nhập địa chỉ khách hàng!");
                txt_DC.Focus();
                return;
            }
            if (listBox_Di.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn điểm đi !"); 
                return;
            }
            if(listBox_Ve.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn điểm về !");
                return;
            }

            DateTime ngaydi = dtp_NgayDi.Value.Date;
            DateTime ngayve = dtp_NgayVe.Value.Date;

            if (ngayve < ngaydi)
            {
                MessageBox.Show("Hãy chọn ngày đi va ngày về" + "\n" + ngaydi + "\n" + ngayve);
                return;
            }
            
            string diemdi = listBox_Di.SelectedIndex.ToString();
            string diemve = listBox_Ve.SelectedIndex.ToString();

            txt_TongNgay.Text = ngayve.Subtract(ngaydi).Days.ToString();
            rbt_ThongTin.Clear();
            rbt_ThongTin.Text = "Khách hàng: " + hoten;
            rbt_ThongTin.Text += "\nNgày sinh: " + ngaysinh;
            rbt_ThongTin.Text += "\nĐịa chỉ: " + diachi;
            rbt_ThongTin.Text += "\nĐiểm đến: " + diemdi;
            rbt_ThongTin.Text += "\nĐiểm về: " + diemve;
            
        }       

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_KH.Clear();
            txt_DC.Clear(); 
            dtp_Ngaysinh.ResetText();
            listBox_Di.SelectedIndex = -1;
            listBox_Ve.SelectedIndex = -1;
            dtp_NgayDi.ResetText();
            dtp_NgayVe.ResetText();
            rbt_ThongTin.Clear();
            txt_KH.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbt_ThongTin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
