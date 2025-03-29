using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == "черный")
                this.listBox1.BackColor = System.Drawing.Color.Black;
            if (this.listBox1.SelectedItem == "зеленый")
                this.listBox1.BackColor = System.Drawing.Color.Green;
            if (this.listBox1.SelectedItem == "синий")
                this.listBox1.BackColor = System.Drawing.Color.Blue;
            if (this.listBox1.SelectedItem == "красный")
                this.listBox1.BackColor = System.Drawing.Color.Red;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedItem == "средняя")
                this.textBox1.Width = 50;
            if (this.listBox2.SelectedItem == "минимальная")
                this.textBox1.Width = 20;
            if (this.listBox2.SelectedItem == "максимальная")
                this.textBox1.Width = 100;

        }
    }
}
