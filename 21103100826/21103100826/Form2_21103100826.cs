using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _21103100826
{
    public partial class Form2_21103100826 : Form
    {
        public Employees NewEmployees { get; internal set; }

        private void LoadComboBoxData()
        {
            List<string> gt = new List<string> { "Nam", "Nữ", "Khác" };
            cb_GioiTinh.DataSource = gt;

            List<string> dt = new List<string> { "Kinh", "Thái", "Mường", "Khmer", "Nùng", "Tày" };
            cb_DanToc.DataSource = dt;
        }

        public Form2_21103100826()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        public void LoadEmployeeData(Employees employee)
        {
            txt_MaNV.Text = employee.MaNV.ToString();
            txt_HoTen.Text = employee.HoTen;
            dtp_NamSinh.Value = employee.Namsinh;
            cb_GioiTinh.SelectedItem = employee.GioiTinh;
            txt_BoPhan.Text = employee.BoPhan;
            txt_ChucVu.Text = employee.ChucVu;
            txt_HopDong.Text = employee.HopDong;
            txt_DiaChi.Text = employee.DiaChi;
            dtp_NgayVao.Value = employee.NgayVao;
            dtp_NgayRa.Value = (DateTime) employee.NgayRa;
            cb_DanToc.SelectedItem = employee.DanToc;
            txt_cccd.Text = employee.CCCD;
            txt_sdt.Text = employee.SDT;
            txt_Email.Text = employee.Email;
            pictureBox1.ImageLocation = employee.ImagePath; // Nạp đường dẫn ảnh
        }


        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            SaveEmployee();
            ClearFields();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            SaveEmployee();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            
            txt_MaNV.Text = string.Empty;
            txt_HoTen.Text = string.Empty;
            txt_BoPhan.Text = string.Empty;
            txt_ChucVu.Text = string.Empty;
            txt_HopDong.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
            txt_cccd.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_Email.Text = string.Empty;

            pictureBox1.Image = null;

            
            dtp_NamSinh.Value = DateTime.Now;
            dtp_NgayVao.Value = DateTime.Now; 
            dtp_NgayRa.Value = DateTime.Now; 

            
            cb_GioiTinh.SelectedIndex = -1; 
            cb_DanToc.SelectedIndex = -1; 
        }
        private void SaveEmployee()
        {
            NewEmployees = new Employees
            {
                MaNV = int.Parse(txt_MaNV.Text),               
                HoTen = txt_HoTen.Text,                         
                Namsinh = dtp_NamSinh.Value,     
                GioiTinh = cb_GioiTinh.SelectedItem.ToString(),                    
                BoPhan = txt_BoPhan.Text,                        
                ChucVu = txt_ChucVu.Text,                        
                HopDong = txt_HopDong.Text,                      
                DiaChi = txt_DiaChi.Text,                        
                NgayVao = dtp_NgayVao.Value,                     
                NgayRa = dtp_NgayRa.Value,                      
                DanToc = cb_DanToc.SelectedItem.ToString(),                        
                CCCD = txt_cccd.Text,                            
                SDT = txt_sdt.Text,                              
                Email = txt_Email.Text,
                ImagePath = pictureBox1.ImageLocation

            };
        }


        
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = openFileDialog.FileName;
                }
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
