using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _21103100826_BTVN_Lap6
{
    public partial class _21103100826_Bai1 : Form
    {
        public _21103100826_Bai1()
        {
            InitializeComponent();
        }
        
        private void HiểnThịComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (HiểnThịComboBox1.SelectedItem.ToString() == "Hiển Thị Thời Gian")
            {
                lbl_tg.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (HiểnThịComboBox1.SelectedItem.ToString() == "Hiển Thị Ngày Tháng Năm")
            {
                lbl_ntn.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
