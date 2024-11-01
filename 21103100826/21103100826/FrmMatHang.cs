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
    public partial class FrmMatHang : Form
    {
        KNCSDL db = new KNCSDL();

        public FrmMatHang()
        {
            InitializeComponent();
        }

        void vohieuhoa(bool gt)
        {
            txt_MaMH_0826.Enabled = gt;
            txt_TenMH_0826.Enabled = gt;
            txt_DVT_0826.Enabled = gt;
        }

        bool kiemtra_du_lieu()
        {
            if (kiemtra(txt_MaMH_0826.Text) || kiemtra(txt_TenMH_0826.Text) || kiemtra(txt_DVT_0826.Text))
            {
                MessageBox.Show("Có trường không hợp lệ!", "Thông báo lỗi");
                return false;
            }
            return true;
        }

        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }

        void reset()
        {
            txt_MaMH_0826.ResetText();
            txt_TenMH_0826.ResetText();
            txt_DVT_0826.ResetText();
        }

        private void Dua_DL_Bang()
        {

            dataGridView1_0826.Rows.Clear();
            foreach (DataRow dr in db.danhSachMathang().Rows)
            {
                int rowIndex = dataGridView1_0826.Rows.Add();
                dataGridView1_0826.Rows[rowIndex].Cells["MaMH"].Value = dr["MaMH"].ToString();
                dataGridView1_0826.Rows[rowIndex].Cells["TenMH"].Value = dr["TenMH"].ToString();
                dataGridView1_0826.Rows[rowIndex].Cells["DVT"].Value = dr["DVT"].ToString();

            }
        }

        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            vohieuhoa(false);
            Dua_DL_Bang();
        }

        private void btn_Them_0826_Click(object sender, EventArgs e)
        {
            if (string.Compare(btn_Them_0826.Text, "Thêm") == 0)
            {
                
                vohieuhoa(true);
                txt_MaMH_0826.Focus();
                btn_Them_0826.Text = "Lưu"; 
            }
            else if (kiemtra_du_lieu())
            {
                
                if (db.kiemTraMaMathang(txt_MaMH_0826.Text))
                {
                    MessageBox.Show("Trùng mã mặt hàng", "Thông báo");
                    txt_MaMH_0826.Focus();
                }
                else
                {
                    try
                    {
                        
                        db.themMathang(txt_MaMH_0826.Text, txt_TenMH_0826.Text, txt_DVT_0826.Text);
                        btn_Them_0826.Text = "Thêm"; 
                        reset(); 
                        vohieuhoa(false); 
                        Dua_DL_Bang(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi trong quá trình thêm: {ex.Message}", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi");
                btn_Them_0826.Text = "Lưu"; 
            }

        }

        private void btn_Xoa_0826_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.xoaMathang(txt_MaMH_0826.Text);
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

        private void btn_Sua_0826_Click(object sender, EventArgs e)
        {
            if (string.Compare(btn_Sua_0826.Text, "Sửa") == 0)
            {
                vohieuhoa(true);
                txt_MaMH_0826.Enabled = false;
                txt_TenMH_0826.Focus();
                btn_Sua_0826.Text = "Cập nhật";
            }
            else if (kiemtra_du_lieu())
            {
                try
                {
                    db.suaMathang(txt_TenMH_0826.Text, txt_MaMH_0826.Text, txt_DVT_0826.Text);
                    btn_Sua_0826.Text = "Sửa";
                    Dua_DL_Bang();
                    vohieuhoa(false);
                    reset();
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

        private void btn_TimKiem_0826_Click(object sender, EventArgs e)
        {
            string ma = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã mặt hàng cần tìm kiếm", "Tìm kiếm");
            if (db.timKiemMathang(ma) != null)
            {
                foreach (DataRow dr in db.timKiemMathang(ma).Rows)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dr["MaMH"].ToString();
                    item.SubItems.Add(dr["TenMH"].ToString());
                    item.SubItems.Add(dr["DVT"].ToString());
                    dataGridView1_0826.Rows.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Tìm kiếm không thấy", "Thông báo tìm kiếm");
            }

        }

        private void btn_Thoat_0826_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_0826_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = dataGridView1_0826.Rows[e.RowIndex];

                    txt_MaMH_0826.Text = row.Cells["MaMH"].Value.ToString();
                    txt_TenMH_0826.Text = row.Cells["TenMH"].Value.ToString();
                    txt_DVT_0826.Text = row.Cells["DVT"].Value.ToString();
                }

            }
        }
    }
}
