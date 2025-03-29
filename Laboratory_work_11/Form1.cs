using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_11
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count;
            double sr;
            for (int i = 0; i < n - 1; i++)
            {
                sr = 0;
                for (int j = 1; j < 5; j++)
                    sr += Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                sr /= 4;
                dataGridView1.Rows[i].Cells[5].Value = sr;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            int n = dataGridView1.Rows.Count;
            dataGridView2.RowCount = n;
            int k = 0; //номер строки в DataGridView2
            for (int i = 0; i < n - 1; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 4.0)
                {
                    for (int j = 0; j < 6; j++)
                        dataGridView2.Rows[k].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                    k++;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            int n = dataGridView1.Rows.Count;
            dataGridView2.RowCount = n;
            int k = 0;

            double r1 = 0;
            double r2 = 0;
            double r3 = 0;
            double r4 = 0;
            double r5 = 0;

            for (int i = 0; i < n - 1; i++)
            {
                        r1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                        r2 += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        r3 += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        r4 += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                        r5 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);

            }
            for (int j = 1; j < 6; j++)
            {
                dataGridView2.Rows[0].Cells[j].Value = r1 / (n - 1);
                dataGridView2.Rows[0].Cells[j].Value = r2 / (n - 1);
                dataGridView2.Rows[0].Cells[j].Value = r3 / (n - 1);
                dataGridView2.Rows[0].Cells[j].Value = r4 / (n - 1);
                dataGridView2.Rows[0].Cells[j].Value = r5 / (n - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            int n = dataGridView1.Rows.Count;
            dataGridView2.RowCount = n;

            double max = 0;
           
            int k = 0; //номер строки в DataGridView2
            
            for (int i = 0; i < n - 1; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value))
                {
                    if (max <= Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value)) {
                        max = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }
            }
            k = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value)) && (max == Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value)))
                {

                    for (int j = 0; j < 6; j++)
                        dataGridView2.Rows[k].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                    k++;
                }
            }
        }
    }
}
