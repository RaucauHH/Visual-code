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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21103100826_Bai1 b1 = new _21103100826_Bai1();
            b1.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21103100826_Bai2 b2 = new _21103100826_Bai2();
            b2.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21103100826_Bai3 b3 = new _21103100826_Bai3();
            b3.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _21103100826_Bai4 b4 = new _21103100826_Bai4();
            b4.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
