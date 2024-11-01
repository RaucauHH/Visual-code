using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21103100826
{
    public partial class FrmKhachHang : Form
    {

        KNCSDL db = new KNCSDL();

        
        public FrmKhachHang()
        {
            InitializeComponent();

            cb_GioiTinh_0826.Items.AddRange(new string[] { "Nam", "Nu", "Khac" });

        }
        
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            Dua_DL_Bang();
        }

        private void Dua_DL_Bang()
        {
            
            dataGridView1_0826.Rows.Clear();
            foreach (DataRow dr in db.danhSachKhachhang().Rows)
            {
                int rowIndex = dataGridView1_0826.Rows.Add();
                dataGridView1_0826.Rows[rowIndex].Cells["MaKH"].Value = dr["MaKH"].ToString();
                dataGridView1_0826.Rows[rowIndex].Cells["Hoten"].Value = dr["Hoten"].ToString();
                dataGridView1_0826.Rows[rowIndex].Cells["Gioitinh"].Value = dr["Gioitinh"].ToString();
                dataGridView1_0826.Rows[rowIndex].Cells["Diachi"].Value = dr["Diachi"].ToString();
                dataGridView1_0826.Rows[rowIndex].Cells["Dienthoai"].Value = dr["Dienthoai"].ToString();
            }
        }

        void vohieuhoa(bool gt)
        {
            groupBox1_0826.Enabled = gt;
        }

        bool kiemtra_du_lieu()
        {
            if (kiemtra(txt_MaKH_0826.Text))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo lỗi");
                txt_MaKH_0826.Focus();
                return false;
            }

            if (kiemtra(txt_HoTen_0826.Text))
            {
                MessageBox.Show("Họ tên không hợp lệ!", "Thông báo lỗi");
                txt_HoTen_0826.Focus();
                return false;
            }

            if (kiemtra(cb_GioiTinh_0826.Text))
            {
                MessageBox.Show("Giới tính không hợp lệ!", "Thông báo lỗi");
                cb_GioiTinh_0826.Focus();
                return false;
            }

            if (kiemtra(txt_DiaChi_0826.Text))
            {
                MessageBox.Show("Địa chỉ không hợp lệ!", "Thông báo lỗi");
                txt_DiaChi_0826.Focus();
                return false;
            }

            if (kiemtra(txt_DienThoai_0826.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo lỗi");
                txt_DienThoai_0826.Focus();
                return false;
            }
            string dt = txt_DienThoai_0826.Text;
            if (dt.Length < 9 || dt.Length > 10)
            {
                MessageBox.Show("Số điện thoại phải có từ 9 đến 10 ký tự!", "Thông báo lỗi");
                txt_DienThoai_0826.Focus();
                return false;
            }
            for (int i = 0; i < dt.Length; i++)
            {
                if ((dt[i] < '0' || dt[i] > '9'))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số!", "Thông báo lỗi");
                    txt_DienThoai_0826.Focus();
                    return false;
                }
            }

            if (dt[0] != '0')
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0!", "Thông báo lỗi");
                txt_DienThoai_0826.Focus();
                return false;
            }

            return true;
        }

        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true; else return false;
        }

        void reset()
        {
            txt_HoTen_0826.ResetText(); 
            txt_MaKH_0826.ResetText();
            cb_GioiTinh_0826.Text = ""; 
            txt_DiaChi_0826.ResetText(); 
            txt_DienThoai_0826.ResetText();
        }



        private void btn_Thoat_0826_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Them_0826_Click(object sender, EventArgs e)
        {
            if (string.Compare(btn_Them_0826.Text, "Thêm") == 0)
            {
                vohieuhoa(true); 
                txt_MaKH_0826.Focus(); 
                btn_Them_0826.Text = "Lưu";
            }
            else if (kiemtra_du_lieu())
            {
               
                if (db.kiemTraMaKhachhang(txt_MaKH_0826.Text))
                {
                    MessageBox.Show("Trùng mã khách hàng", "Thông báo"); 
                    txt_MaKH_0826.Focus();
                }
                else
                {
                    try
                    {
                        db.themKhachhang(txt_MaKH_0826.Text, txt_HoTen_0826.Text, cb_GioiTinh_0826.Text, txt_DiaChi_0826.Text, txt_DienThoai_0826.Text);
                        reset(); 
                        btn_Them_0826.Text = "Thêm"; 
                        vohieuhoa(false);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm!", "Thông báo");
                    }
                }
                Dua_DL_Bang();
            }
            else 
            { 
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi"); 
                btn_Them_0826.Text = "Lưu"; 
            }
        }

        private void btn_Sua_0826_Click(object sender, EventArgs e)
        {
            if (string.Compare(btn_Sua_0826.Text, "Sửa") == 0)
            {
                vohieuhoa(true);
                txt_MaKH_0826.Enabled = false;
                txt_HoTen_0826.Focus();
                btn_Sua_0826.Text = "Cập nhật";
            }
            else if (kiemtra_du_lieu())
            {
                try
                {
                    db.suaKhachhang(txt_HoTen_0826.Text, cb_GioiTinh_0826.Text, txt_DiaChi_0826.Text, txt_DienThoai_0826.Text, txt_MaKH_0826.Text);
                    btn_Sua_0826.Text = "Sửa";
                    vohieuhoa(false);
                    reset();
                    Dua_DL_Bang();
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình sửa!", "Thông báo lỗi");
                }

            }
            else 
            { 
                MessageBox.Show("Dữ liệu sửa không hợp lệ"); 
                btn_Sua_0826.Text = "Cập nhật"; 
            }
        
        }

        private void btn_Xoa_0826_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.xoaKhachhang(txt_MaKH_0826.Text);
                    dataGridView1_0826.Rows.Clear();
                    Dua_DL_Bang(); 
                    reset();
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi xóa!", "Thông báo lỗi");
                }
            }

        }

        private void btn_TimKiem_0826_Click(object sender, EventArgs e)
        {
            
            string ma = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã khách hàng cần tìm kiếm", "Tìm kiếm");

            
            DataTable resultTable = db.timKiemKhachhang(ma);
            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                dataGridView1_0826.Rows.Clear();

                foreach (DataRow dr in resultTable.Rows)
                {
                    int rowIndex = dataGridView1_0826.Rows.Add();
                    dataGridView1_0826.Rows[rowIndex].Cells["MaKH"].Value = dr["MaKH"].ToString();
                    dataGridView1_0826.Rows[rowIndex].Cells["Hoten"].Value = dr["Hoten"].ToString();
                    dataGridView1_0826.Rows[rowIndex].Cells["Gioitinh"].Value = dr["Gioitinh"].ToString();
                    dataGridView1_0826.Rows[rowIndex].Cells["Diachi"].Value = dr["Diachi"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Tìm kiếm không thấy", "Thông báo tìm kiếm");
            }

        }

            private void dataGridView1_0826_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    
                    DataGridViewRow row = dataGridView1_0826.Rows[e.RowIndex];

                    txt_MaKH_0826.Text = row.Cells["MaKH"].Value.ToString();
                    txt_HoTen_0826.Text = row.Cells["Hoten"].Value.ToString();
                    cb_GioiTinh_0826.SelectedItem = row.Cells["Gioitinh"].Value.ToString();
                    txt_DiaChi_0826.Text = row.Cells["Diachi"].Value.ToString();
                    txt_DienThoai_0826.Text = row.Cells["Dienthoai"].Value.ToString();
                }
                
            }
            
        }

        private void groupBox1_0826_Enter(object sender, EventArgs e)
        {

        }
    }
}
