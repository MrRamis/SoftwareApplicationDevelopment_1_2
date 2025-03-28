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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int bal = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (bal)
            {
                case 1:
                    label4.Text = "удовлетворительно";
                    break;
                case 2:
                    label4.Text = "хорошо";
                    break;
                case 3:
                    label4.Text = "отлично";
                    break;
                default:
                    label4.Text = "неудовлетворительно";
                    break;
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                bal++;
            else
                bal--;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
                bal++;
            else
                bal--;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                bal++;
            else
                bal--;
        }
    }
}
