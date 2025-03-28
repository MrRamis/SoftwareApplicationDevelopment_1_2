namespace wp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = System.Int32.Parse(this.txtA.Text);
            int b = System.Int32.Parse(this.txtB.Text);
            int c = System.Int32.Parse(this.txtC.Text);
            int summa = a + b + c;
            this.txtSumma.Text = summa.ToString();

        }
    }
}
