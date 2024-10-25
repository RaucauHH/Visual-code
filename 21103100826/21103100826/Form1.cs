using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _21103100826
{
    public partial class Form1 : Form
    {
        private List<Employees> employees = new List<Employees>();
        private int currentIndex = -1;
        private string filePath = "employees_msv.json";  

        
        private void LoadEmployees()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                employees = JsonConvert.DeserializeObject<List<Employees>>(json);
                dataGridView1.DataSource = employees;
                foreach (var employee in employees)
                {
                    if (!string.IsNullOrEmpty(employee.ImagePath) && File.Exists(employee.ImagePath))
                    {
                         pictureBox1.ImageLocation = employee.ImagePath; 
                    }
                }
            }
        }

        
        private void SaveEmployees()
        {
            string json = JsonConvert.SerializeObject(employees);
            File.WriteAllText(filePath, json);
        }

        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
        }

        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Form2_21103100826 form2 = new Form2_21103100826();
            form2.Owner = this;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                employees.Add(form2.NewEmployees);
                SaveEmployees();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = employees;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentIndex = e.RowIndex;
                ShowInfo(currentIndex);
            }
        }
        private void ShowInfo(int index)
        {
            if (index >= 0 && index < employees.Count)
            {
                var employee = employees[index];
                richTextBox1.Text = $"MaNV: {employee.MaNV}\nHoTen: {employee.HoTen}\nNamsinh: {employee.Namsinh}\nGioiTinh: {employee.GioiTinh}\nBoPhan: {employee.BoPhan}\nChucVu: {employee.ChucVu}\nHopDong: {employee.HopDong}\nDiaChi: {employee.DiaChi}\nNgayVao: {employee.NgayVao}\nNgayRa: {employee.NgayRa}\nDanToc: {employee.DanToc}\nCCCD: {employee.CCCD}\nSDT: {employee.SDT}\nEmail: {employee.Email}";
                
                if (!string.IsNullOrEmpty(employee.ImagePath) && File.Exists(employee.ImagePath))
                {
                    pictureBox1.ImageLocation = employee.ImagePath;
                }
                else
                {
                    pictureBox1.Image = null; 
                }

                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Selected = true;
            }

            
        }

        private void btn_Lui_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowInfo(currentIndex);
            }
            else
            {
                MessageBox.Show("Đã đến nhân viên đầu tiên.");
            }
        }

        private void btn_Tien_Click(object sender, EventArgs e)
        {
            if (currentIndex < employees.Count - 1)
            {
                currentIndex++;
                ShowInfo(currentIndex);
            }
            else
            {
                MessageBox.Show("Đã đến nhân viên cuối cùng.");
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < employees.Count)
            {
                employees.RemoveAt(currentIndex);
                SaveEmployees();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = employees;
                richTextBox1.Clear();
                pictureBox1.Image = null;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < employees.Count)
            {
                Form2_21103100826 form2 = new Form2_21103100826();
                form2.Owner = this;
                form2.LoadEmployeeData(employees[currentIndex]); 
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    employees[currentIndex] = form2.NewEmployees; 
                    SaveEmployees();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = employees;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string timkiemtheoma = txt_TimKiem.Text.ToLower();
            var kqtimkiem = employees.Where(emp => emp.HoTen.ToLower().Contains(timkiemtheoma) || emp.MaNV.ToString().Contains(timkiemtheoma)).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kqtimkiem;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
