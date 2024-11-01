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
    public partial class FrmQLBH_21103100826 : Form
    {
        public FrmQLBH_21103100826()
        {
            InitializeComponent();
        }
        
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        
        private void thôngtinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKH = new FrmKhachHang();
            frmKH.ShowDialog();
        }


        private void thôngTinMặtHàng0826ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatHang frmMH = new FrmMatHang();
            frmMH.ShowDialog();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang frmBH = new FrmBanHang();
            frmBH.ShowDialog();
        }

        private void tìmKiếmKháchHàng0826ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemKH frmTimKiemKH = new FrmTimKiemKH();
            frmTimKiemKH.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemMH frmTimKiemMH = new FrmTimKiemMH();
            frmTimKiemMH.ShowDialog();
        }

        private void tìmKiếmThôngTinBánHàng0826ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemTTBH frmTimKiemTTBH = new FrmTimKiemTTBH();
            frmTimKiemTTBH.ShowDialog();
        }

        
    }
}
