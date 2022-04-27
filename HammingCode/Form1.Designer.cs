namespace HammingCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź dane binarne:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Koduj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(212, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bity kontrolne";
            this.groupBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "C64 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "C2 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "C4 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "C8 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "C16 = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "C32 = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "C1 = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Zakodowane słowo:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(524, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 46);
            this.label9.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autorzy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Karol Nowiński";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Jakub Rymuza";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Mateusz Szymczak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kodowanie Hamminga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox2;
        private Label label13;
        private Label label12;
        private Label label11;
    }
}