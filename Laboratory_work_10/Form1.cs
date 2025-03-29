using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_10
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float value; // сумма кредита
            int period; // срок
            float rate; // процентная ставка 
            int month; // месяц платежа 
            float debt; // долг на начало текущего месяца 
            float interest; // плата за кредит (проценты на долг) 
            float paying; // сумма платежа 
            float suminterest; // общая плата за кредит 
            float sumpaying;
            // сумма
            value = System.Convert.ToSingle(textBox1.Text);
            // срок
            period = System.Convert.ToInt32(textBox2.Text);
            // процентная ставка
            rate = System.Convert.ToSingle(textBox3.Text);
            month = 1;
            debt = value; // долг на начало первого месяца 
            suminterest = 0;
            sumpaying = 0;
            // расчет для каждого месяца
            for (int i = 0; i < period; i++)
            {
                interest = debt * (rate / 12 / 100);
                suminterest += interest;
                paying = value / period + interest;
                // добавить в listView1 элемент -
                // строку (данные в первый столбец) 
                listView1.Items.Add(month.ToString());
                // добавить в добавленную строку подэлементы -
                // данные во второй, третий и четвертый столбцы 
                listView1.Items[i].SubItems.Add(debt.ToString("c"));
                listView1.Items[i].SubItems.Add(interest.ToString("c"));
                listView1.Items[i].SubItems.Add(paying.ToString("c"));
                sumpaying += paying;
                month++;
                debt = debt - value / period;
            }
            listView1.Items.Add("Итог");
            listView1.Items[period].SubItems.Add("");
            listView1.Items[period].SubItems.Add(suminterest.ToString("c"));
            listView1.Items[period].SubItems.Add(sumpaying.ToString("c"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
