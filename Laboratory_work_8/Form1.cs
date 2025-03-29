using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_8
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.Black;
            черныйToolStripMenuItem.Enabled = false;

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.Red;
            красныйToolStripMenuItem.Enabled = false;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            синийToolStripMenuItem.Enabled = false;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.BackColor = System.Drawing.Color.Green;
            зеленыйToolStripMenuItem.Enabled = false;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            белыйToolStripMenuItem.Enabled = false;
        }

        private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            синийToolStripMenuItem1.Enabled = false;
        }

        private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            красныйToolStripMenuItem1.Enabled = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            выходToolStripMenuItem.Enabled = false;
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик – Шарибжанов Рамис Фяритович", "Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
            разработчикToolStripMenuItem.Enabled = false;

        }
    }
}
