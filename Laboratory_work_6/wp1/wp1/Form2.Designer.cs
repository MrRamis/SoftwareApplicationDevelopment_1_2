namespace wp1
{
    partial class Form2
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
            label1 = new Label();
            txtA = new TextBox();
            label4 = new Label();
            txtSumma = new TextBox();
            btnExit = new Button();
            btnCount = new Button();
            label2 = new Label();
            txtB = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 4;
            label1.Text = "A=";
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 12F);
            txtA.Location = new Point(45, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 29);
            txtA.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(171, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 10;
            label4.Text = "Решение";
            // 
            // txtSumma
            // 
            txtSumma.Font = new Font("Segoe UI", 12F);
            txtSumma.Location = new Point(171, 33);
            txtSumma.Name = "txtSumma";
            txtSumma.Size = new Size(213, 29);
            txtSumma.TabIndex = 11;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(294, 78);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 33);
            btnExit.TabIndex = 13;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 12F);
            btnCount.Location = new Point(171, 78);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(90, 33);
            btnCount.TabIndex = 12;
            btnCount.Text = "Вычислить";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 50);
            label2.Name = "label2";
            label2.Size = new Size(30, 21);
            label2.TabIndex = 14;
            label2.Text = "B=";
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 12F);
            txtB.Location = new Point(45, 47);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 29);
            txtB.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 16;
            label3.Text = "C=";
            // 
            // txtC
            // 
            txtC.Font = new Font("Segoe UI", 12F);
            txtC.Location = new Point(45, 82);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 29);
            txtC.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 121);
            Controls.Add(label3);
            Controls.Add(txtC);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(label4);
            Controls.Add(txtSumma);
            Controls.Add(label1);
            Controls.Add(txtA);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private Label label4;
        private TextBox txtSumma;
        private Button btnExit;
        private Button btnCount;
        private Label label2;
        private TextBox txtB;
        private Label label3;
        private TextBox txtC;
    }
}