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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent(); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == "Мышь") {
                textBox1.Text = "Мышь — это механический манипулятор для ручного управления перемещением курсора на экране компьютера. При перемещении мыши по столу или иной поверхности происходит аналогичное перемещение курсора на экране монитора. С помощью клавиш мыши можно подавать команды компьютеру";
                pictureBox1.Image = Image.FromFile("kak-vybrat-igrovuyu-mysh-01_3.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (this.listBox1.SelectedItem == "Клавиатура")
            {
                textBox1.Text = "Клавиатура — комплект клавиш для управления каким-либо устройством или для ввода данных.";
                pictureBox1.Image = Image.FromFile("r.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (this.listBox1.SelectedItem == "Процессор")
            {
                textBox1.Text = "Процессор — главный компонент компьютера, который выполняет все вычисления и управляет другими системами. Он извлекает инструкции из памяти, выполняет вычисления и отправляет результаты назад.";
                pictureBox1.Image = Image.FromFile("pro.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (this.listBox1.SelectedItem == "Монитор")
            {
                textBox1.Text = "Монитор — это устройство для визуального отображения информации, передаваемой компьютером.";
                pictureBox1.Image = Image.FromFile("mon.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
