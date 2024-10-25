using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap9
{
    public partial class FormKH : Form
    {
           
        public FormKH()
        {
            InitializeComponent();
        }
        KNCSDL kn = new KNCSDL();
        void DuaDLVaoBang()
        {
            dataGridView1.DataSource = kn.getAllKH();
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_BTDataSet.tblKhachHang' table. You can move, or remove it, as needed.
           DuaDLVaoBang();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[i];
                txt_MaKH.Text = row.Cells[0].Value.ToString();
                txt_HoTen.Text = row.Cells[1].Value.ToString();
                cb_GioiTinh.Text = row.Cells[2].Value.ToString();
                txt_dc.Text = row.Cells[3].Value.ToString();
                txt_dt.Text = row.Cells[4].Value.ToString();
            }
        }

        void ClearTexts()
        {
            txt_MaKH.Clear();
            txt_HoTen.Clear();
            cb_GioiTinh.SelectedIndex = -1;
            txt_dc.Clear();
            txt_dt.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaKH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã!");
                txt_MaKH.Focus();
                return;
            }
            if (txt_HoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập họ tên!");
                txt_HoTen.Focus();
                return;
            }
            if (cb_GioiTinh.Text == "")
            {
                MessageBox.Show("Chưa chọn giới tính!");
                cb_GioiTinh.Focus();
                return;
            }

            if (kn.TonTaiKH(txt_MaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                txt_MaKH.Focus();
                return;
            }
            kn.ThemKH(txt_MaKH.Text.Trim(), txt_HoTen.Text, cb_GioiTinh.Text, txt_dc.Text, txt_dt.Text);
            DuaDLVaoBang();
            ClearTexts();
            MessageBox.Show("Thêm thành công !");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows == null) return;
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null) return;
            if(MessageBox.Show("Có chắc chắn muốn xóa không !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                        string ma = row.Cells[0].Value.ToString();
                        kn.XoaKH(ma);
                    
                }
                DuaDLVaoBang() ;
                ClearTexts();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Có chắc chắn muốn thoát không !", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }
    }
}
