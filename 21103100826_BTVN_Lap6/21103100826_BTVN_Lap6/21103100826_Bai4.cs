using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21103100826_BTVN_Lap6
{
    public partial class _21103100826_Bai4 : Form
    {
        public _21103100826_Bai4()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4_HoTro ht = new Bai4_HoTro();
            ht.ShowDialog();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4_ThongTin tt = new Bai4_ThongTin();
            tt.ShowDialog();

        }
    }
}
