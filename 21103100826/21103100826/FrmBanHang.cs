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
    public partial class FrmBanHang : Form
    {
        KNCSDL db = new KNCSDL();
        int d = 0;
        public FrmBanHang()
        {
            InitializeComponent();
        }

        bool kiemtra_du_lieu()
        {
            if (kiemtra(txt_SoHieuHD_0826.Text) || kiemtra(txt_MaKH_0826.Text) || kiemtra(dtp_NgayMua.Text) || kiemtra(txt_MaMH_0826.Text)
            || kiemtra(txt_SoLuong_0826.Text) || kiemtra(txt_DonGia_0826.Text)) return false;
            int shd; 
            double dongia;
            if (!int.TryParse(txt_SoHieuHD_0826.Text, out shd)) return false;
            if (!int.TryParse(txt_SoLuong_0826.Text, out shd)) return false;
            if (!double.TryParse(txt_DonGia_0826.Text, out dongia)) return false;
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
            txt_SoLuong_0826.ResetText();
            txt_DonGia_0826.ResetText();
        }

        void vohieuhoa1(bool gt)
        {
            txt_SoHieuHD_0826.Enabled = gt; 
            txt_MaKH_0826.Enabled = gt; 
            dtp_NgayMua.Enabled = gt;
        }

        void vohieuhoa2(bool gt)
        {
            txt_SoHieuHD_0826.Enabled = gt; 
            txt_MaKH_0826.Enabled = gt; 
            dtp_NgayMua.Enabled = gt; 
            txt_MaMH_0826.Enabled = gt; 
            txt_SoLuong_0826.Enabled = gt; 
            txt_DonGia_0826.Enabled = gt;
        }


        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            vohieuhoa2(false); 
            btn_Sua_0826.Enabled = false; 
            btn_Xoa_0826.Enabled = false;
        }

        private void Dua_DL_VaoBang(string soHoadon)
        {
            dataGridView1_0826.Rows.Clear(); 

            int d = 1; 
            foreach (DataRow dr in db.danhSachChitietMathang(soHoadon).Rows)
            {
                int rowIndex = dataGridView1_0826.Rows.Add();
                DataGridViewRow row = dataGridView1_0826.Rows[rowIndex];

                row.Cells["STT"].Value = d; 
                row.Cells["MaMH"].Value = dr["MaMH"].ToString(); 
                row.Cells["SoLuong"].Value = dr["SoLuong"].ToString(); 
                row.Cells["DonGia"].Value = dr["DonGia"].ToString();

                row.Cells["ThanhTien"].Value = (int.Parse(dr["SoLuong"].ToString()) * float.Parse(dr["DonGia"].ToString())).ToString();

                d++; 
            }
        }

        private void btn_Them_0826_Click(object sender, EventArgs e)
        {
            if (string.Compare(btn_Them_0826.Text, "Thêm") == 0)
            {
                if (d == 0)
                {
                    vohieuhoa2(true); 
                    btn_Xoa_0826.Enabled = true;
                    btn_Sua_0826.Enabled = true;
                }
                else
                {
                    vohieuhoa1(true); vohieuhoa1(false);
                }
                txt_MaMH_0826.Enabled = true; 
                btn_Them_0826.Text = "Lưu";
            }
            else if (kiemtra_du_lieu())
            {
                if (db.kiemTraSoHoadon(txt_SoHieuHD_0826.Text) && d == 0)
                {
                    MessageBox.Show("Số hiệu hóa đơn đã tồn tại.\nKiểm tra lại!");
                    txt_SoHieuHD_0826.Focus();
                }
                else
                {
                    if (!db.kiemTraSoHoadon(txt_SoHieuHD_0826.Text))
                    {
                        db.themBanhang(txt_SoHieuHD_0826.Text, txt_MaKH_0826.Text, Convert.ToDateTime(dtp_NgayMua.Text));
                        btn_Them_0826.Text = "Thêm"; vohieuhoa1(false);
                    }
                    db.themChitietBanhang(txt_SoHieuHD_0826.Text, txt_MaMH_0826.Text, int.Parse(txt_SoLuong_0826.Text), float.Parse(txt_DonGia_0826.Text));
                    reset(); 
                    btn_Them_0826.Text = "Thêm"; 
                    vohieuhoa1(false); d++;
                    Dua_DL_VaoBang(txt_SoHieuHD_0826.Text);
                }
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
                txt_SoHieuHD_0826.Enabled = false; 
                txt_MaKH_0826.Enabled = false; 
                dtp_NgayMua.Enabled = false; 
                txt_MaMH_0826.Enabled = false; 
                btn_Sua_0826.Text = "Cập nhật";
            }
            else if (kiemtra_du_lieu())
            {
                for (int i = 0; i < dataGridView1_0826.Rows.Count; i++)
                {
                    db.suaChitietBanhang(int.Parse(txt_SoLuong_0826.Text), float.Parse(txt_DonGia_0826.Text), txt_MaMH_0826.Text);
                    Dua_DL_VaoBang(txt_SoHieuHD_0826.Text);
                }
                btn_Sua_0826.Text = "Sửa";
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
                db.xoaChitietBanHang(int.Parse(txt_SoHieuHD_0826.Text), txt_MaMH_0826.Text);
                Dua_DL_VaoBang(txt_SoHieuHD_0826.Text);
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
                    txt_SoLuong_0826.Text = row.Cells["SoLuong"].Value.ToString();
                    txt_DonGia_0826.Text = row.Cells["DonGia"].Value.ToString();
                }
            }
        }
    }
}
