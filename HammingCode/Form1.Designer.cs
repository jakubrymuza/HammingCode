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
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEncodedWord = new System.Windows.Forms.Label();
            this.lblEncodedWordText = new System.Windows.Forms.Label();
            this.groupControlBits = new System.Windows.Forms.GroupBox();
            this.lblC8 = new System.Windows.Forms.Label();
            this.lblC4 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCorrectWord = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupControlBits.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Mateusz Szymczak";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Karol Nowiński";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(876, 462);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEncodedWord);
            this.tabPage1.Controls.Add(this.lblEncodedWordText);
            this.tabPage1.Controls.Add(this.groupControlBits);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.txtEncode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(868, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kodowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEncodedWord
            // 
            this.lblEncodedWord.AutoSize = true;
            this.lblEncodedWord.Location = new System.Drawing.Point(371, 349);
            this.lblEncodedWord.Name = "lblEncodedWord";
            this.lblEncodedWord.Size = new System.Drawing.Size(0, 20);
            this.lblEncodedWord.TabIndex = 10;
            // 
            // lblEncodedWordText
            // 
            this.lblEncodedWordText.AutoSize = true;
            this.lblEncodedWordText.Location = new System.Drawing.Point(224, 349);
            this.lblEncodedWordText.Name = "lblEncodedWordText";
            this.lblEncodedWordText.Size = new System.Drawing.Size(141, 20);
            this.lblEncodedWordText.TabIndex = 9;
            this.lblEncodedWordText.Text = "Zakodowane słowo:";
            this.lblEncodedWordText.Visible = false;
            // 
            // groupControlBits
            // 
            this.groupControlBits.Controls.Add(this.lblC8);
            this.groupControlBits.Controls.Add(this.lblC4);
            this.groupControlBits.Controls.Add(this.lblC2);
            this.groupControlBits.Controls.Add(this.lblC1);
            this.groupControlBits.Controls.Add(this.label7);
            this.groupControlBits.Controls.Add(this.label6);
            this.groupControlBits.Controls.Add(this.label5);
            this.groupControlBits.Controls.Add(this.label2);
            this.groupControlBits.Location = new System.Drawing.Point(218, 128);
            this.groupControlBits.Name = "groupControlBits";
            this.groupControlBits.Size = new System.Drawing.Size(435, 169);
            this.groupControlBits.TabIndex = 8;
            this.groupControlBits.TabStop = false;
            this.groupControlBits.Text = "Bity kontrolne";
            this.groupControlBits.Visible = false;
            // 
            // lblC8
            // 
            this.lblC8.AutoSize = true;
            this.lblC8.Location = new System.Drawing.Point(64, 83);
            this.lblC8.Name = "lblC8";
            this.lblC8.Size = new System.Drawing.Size(58, 20);
            this.lblC8.TabIndex = 10;
            this.lblC8.Text = "label24";
            // 
            // lblC4
            // 
            this.lblC4.AutoSize = true;
            this.lblC4.Location = new System.Drawing.Point(64, 62);
            this.lblC4.Name = "lblC4";
            this.lblC4.Size = new System.Drawing.Size(58, 20);
            this.lblC4.TabIndex = 9;
            this.lblC4.Text = "label23";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(64, 45);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(58, 20);
            this.lblC2.TabIndex = 8;
            this.lblC2.Text = "label22";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(64, 25);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(58, 20);
            this.lblC1.TabIndex = 7;
            this.lblC1.Text = "label21";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "C1 = ";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(380, 62);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(94, 29);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "Koduj";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.EncodeButtonClick);
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(418, 14);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(235, 27);
            this.txtEncode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wprowadź dane binarne:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.lblCorrectWord);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(868, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dekodowanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCorrectWord
            // 
            this.lblCorrectWord.AutoSize = true;
            this.lblCorrectWord.Location = new System.Drawing.Point(426, 32);
            this.lblCorrectWord.Name = "lblCorrectWord";
            this.lblCorrectWord.Size = new System.Drawing.Size(314, 20);
            this.lblCorrectWord.TabIndex = 6;
            this.lblCorrectWord.Text = "Zakoduj słowo, używając modułu kodowania...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(206, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 147);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wynik";
            this.groupBox3.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Syndrom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Nowe bity kontrolne:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Pierwotne bity kontrolne:";
            // 
            // btnDecode
            // 
            this.btnDecode.Enabled = false;
            this.btnDecode.Location = new System.Drawing.Point(348, 125);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(94, 29);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "Sprawdź";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Przekłamany bit nr:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Słowo poprawne:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(426, 78);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 27);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Kodowanie Hamminga";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupControlBits.ResumeLayout(false);
            this.groupControlBits.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label9;
        private GroupBox groupBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private Button btnDecode;
        private Label label15;
        private Label label14;
        private GroupBox groupBox3;
        private Label label18;
        private Label label17;
        private Label label16;
        private TabPage tabPage1;
        private Label lblEncodedWord;
        private Label lblEncodedWordText;
        private GroupBox groupControlBits;
        private Label lblC8;
        private Label lblC4;
        private Label lblC2;
        private Label lblC1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button btnEncode;
        private TextBox txtEncode;
        private Label label1;
        private Label label10;
        private Label label4;
        private Label label3;
        private Label lblCorrectWord;
        private NumericUpDown numericUpDown1;
    }
}