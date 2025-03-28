using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                label1.Font = new Font("Times New Roman", 14.0f);
            if (checkBox1.Checked == false)
                label1.Font = new Font("Courier New", 14.0f);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox2.Checked == true)
                label1.Font = new Font("Courier New", 14.0f, FontStyle.Italic);
            else
                label1.Font = new Font("Courier New", 14.0f);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                label1.Font = new Font("Courier New", 14.0f, FontStyle.Underline);
            else
                label1.Font = new Font("Courier New", 14.0f);
        }
    }
}
