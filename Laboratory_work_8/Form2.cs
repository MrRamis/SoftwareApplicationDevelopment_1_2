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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Text = "Текстовый редактор";
            openFileDialog1.FileName = "D:\\Text2.txt";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null) return;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = System.IO.File.ReadAllText(filename);
                textBox1.Text = fileText;
                MessageBox.Show("Файл открыт");
            }
            catch (System.IO.FileNotFoundException err)
{
                MessageBox.Show(err.Message + "\nФайл не найден", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
              {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, textBox1.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void курсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Courier New", 14.0f, FontStyle.Italic);
        }

        private void жирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Courier New", 14.0f, FontStyle.Underline);
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Courier New", 14.0f);
        }
    }
}
