namespace wp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCount = new Button();
            label1 = new Label();
            txtA = new TextBox();
            label2 = new Label();
            txtB = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            label4 = new Label();
            txtSumma = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 12F);
            btnCount.Location = new Point(136, 146);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(90, 33);
            btnCount.TabIndex = 0;
            btnCount.Text = "Вычислить";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 2;
            label1.Text = "A=";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 12F);
            txtA.Location = new Point(76, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 29);
            txtA.TabIndex = 3;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(196, 18);
            label2.Name = "label2";
            label2.Size = new Size(30, 21);
            label2.TabIndex = 4;
            label2.Text = "B=";
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 12F);
            txtB.Location = new Point(233, 15);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 29);
            txtB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(344, 18);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 6;
            label3.Text = "C=";
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 12F);
            txtC.Location = new Point(381, 15);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 29);
            txtC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(171, 82);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 8;
            label4.Text = "Сумма=";
            // 
            // txtSumma
            // 
            txtSumma.Font = new Font("Segoe UI", 12F);
            txtSumma.Location = new Point(246, 79);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(100, 29);
            txtSumma.TabIndex = 9;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(344, 146);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 191);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(txtSumma);
            Controls.Add(label3);
            Controls.Add(txtC);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(btnCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCount;
        private Label label1;
        private TextBox txtA;
        private Label label2;
        private TextBox txtB;
        private Label label3;
        private TextBox txtC;
        private Label label4;
        private TextBox txtSumma;
        private Button btnExit;
    }
}
