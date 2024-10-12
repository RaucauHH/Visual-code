using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_3Menu_Bai1
{
    public partial class Formcau2 : Form
    {
        public Formcau2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "txt File | *.txt";
            if(dl.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamrd = new StreamReader(dl.FileName);
                richTextBox1.Text = streamrd.ReadToEnd();
                streamrd.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dl = new SaveFileDialog();
            dl.Filter = "txt File | *.txt";
            if(dl.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamwr = new StreamWriter(dl.FileName);
                foreach (String st in richTextBox1.Lines)
                {
                    streamwr.WriteLine(st);
                }
                streamwr.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
