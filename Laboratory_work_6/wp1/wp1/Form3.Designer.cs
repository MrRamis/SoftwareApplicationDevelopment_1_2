namespace wp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtB = new TextBox();
            label1 = new Label();
            txtA = new TextBox();
            label4 = new Label();
            txtSumma = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 79);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 18;
            label2.Text = "Введите второе число";
            label2.Click += label2_Click;
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 12F);
            txtB.Location = new Point(187, 76);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 29);
            txtB.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 16;
            label1.Text = "Введите первое число";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 12F);
            txtA.Location = new Point(187, 14);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 29);
            txtA.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(322, 82);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 20;
            label4.Text = "Ответ";
            // 
            // txtSumma
            // 
            txtSumma.Font = new Font("Segoe UI", 12F);
            txtSumma.Location = new Point(380, 79);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(100, 29);
            txtSumma.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(321, 14);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 22;
            label3.Text = "Выберите операцию";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(329, 43);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 23;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(365, 43);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 24;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(401, 43);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 25;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(437, 43);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 26;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 124);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtSumma);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtB;
        private Label label1;
        private TextBox txtA;
        private Label label4;
        private TextBox txtSumma;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}