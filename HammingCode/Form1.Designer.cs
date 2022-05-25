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
            this.CodedWordLabel = new System.Windows.Forms.Label();
            this.CodedWordDescLabel = new System.Windows.Forms.Label();
            this.ControlBitsGroupBox = new System.Windows.Forms.GroupBox();
            this.C8Label = new System.Windows.Forms.Label();
            this.C4Label = new System.Windows.Forms.Label();
            this.C2Label = new System.Windows.Forms.Label();
            this.C1Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codeButton = new System.Windows.Forms.Button();
            this.ToCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TransmittedWordLabel = new System.Windows.Forms.Label();
            this.TransmittedWordDescriptionLabel = new System.Windows.Forms.Label();
            this.DecodedWordLabel = new System.Windows.Forms.Label();
            this.DecodedWordDescriptionLabel = new System.Windows.Forms.Label();
            this.DecodeInputTextBox = new System.Windows.Forms.TextBox();
            this.ResultGroupBox = new System.Windows.Forms.GroupBox();
            this.SyndromeLabel = new System.Windows.Forms.Label();
            this.NewControlBitsLabel = new System.Windows.Forms.Label();
            this.OriginalControlBitsLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.decodeButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ControlBitsGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(523, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 46);
            this.label9.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(293, 12);
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
            this.tabControl1.Size = new System.Drawing.Size(875, 461);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CodedWordLabel);
            this.tabPage1.Controls.Add(this.CodedWordDescLabel);
            this.tabPage1.Controls.Add(this.ControlBitsGroupBox);
            this.tabPage1.Controls.Add(this.codeButton);
            this.tabPage1.Controls.Add(this.ToCodeTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(867, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kodowanie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CodedWordLabel
            // 
            this.CodedWordLabel.AutoSize = true;
            this.CodedWordLabel.Location = new System.Drawing.Point(371, 349);
            this.CodedWordLabel.Name = "CodedWordLabel";
            this.CodedWordLabel.Size = new System.Drawing.Size(0, 20);
            this.CodedWordLabel.TabIndex = 10;
            // 
            // CodedWordDescLabel
            // 
            this.CodedWordDescLabel.AutoSize = true;
            this.CodedWordDescLabel.Location = new System.Drawing.Point(224, 349);
            this.CodedWordDescLabel.Name = "CodedWordDescLabel";
            this.CodedWordDescLabel.Size = new System.Drawing.Size(141, 20);
            this.CodedWordDescLabel.TabIndex = 9;
            this.CodedWordDescLabel.Text = "Zakodowane słowo:";
            this.CodedWordDescLabel.Visible = false;
            // 
            // ControlBitsGroupBox
            // 
            this.ControlBitsGroupBox.Controls.Add(this.C8Label);
            this.ControlBitsGroupBox.Controls.Add(this.C4Label);
            this.ControlBitsGroupBox.Controls.Add(this.C2Label);
            this.ControlBitsGroupBox.Controls.Add(this.C1Label);
            this.ControlBitsGroupBox.Controls.Add(this.label7);
            this.ControlBitsGroupBox.Controls.Add(this.label6);
            this.ControlBitsGroupBox.Controls.Add(this.label5);
            this.ControlBitsGroupBox.Controls.Add(this.label2);
            this.ControlBitsGroupBox.Location = new System.Drawing.Point(218, 128);
            this.ControlBitsGroupBox.Name = "ControlBitsGroupBox";
            this.ControlBitsGroupBox.Size = new System.Drawing.Size(435, 169);
            this.ControlBitsGroupBox.TabIndex = 8;
            this.ControlBitsGroupBox.TabStop = false;
            this.ControlBitsGroupBox.Text = "Bity kontrolne";
            this.ControlBitsGroupBox.Visible = false;
            // 
            // C8Label
            // 
            this.C8Label.AutoSize = true;
            this.C8Label.Location = new System.Drawing.Point(64, 96);
            this.C8Label.Name = "C8Label";
            this.C8Label.Size = new System.Drawing.Size(58, 20);
            this.C8Label.TabIndex = 10;
            this.C8Label.Text = "label24";
            // 
            // C4Label
            // 
            this.C4Label.AutoSize = true;
            this.C4Label.Location = new System.Drawing.Point(64, 76);
            this.C4Label.Name = "C4Label";
            this.C4Label.Size = new System.Drawing.Size(58, 20);
            this.C4Label.TabIndex = 9;
            this.C4Label.Text = "label23";
            // 
            // C2Label
            // 
            this.C2Label.AutoSize = true;
            this.C2Label.Location = new System.Drawing.Point(64, 56);
            this.C2Label.Name = "C2Label";
            this.C2Label.Size = new System.Drawing.Size(58, 20);
            this.C2Label.TabIndex = 8;
            this.C2Label.Text = "label22";
            // 
            // C1Label
            // 
            this.C1Label.AutoSize = true;
            this.C1Label.Location = new System.Drawing.Point(64, 36);
            this.C1Label.Name = "C1Label";
            this.C1Label.Size = new System.Drawing.Size(58, 20);
            this.C1Label.TabIndex = 7;
            this.C1Label.Text = "label21";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "C2 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "C4 = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "C8 = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "C1 = ";
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(379, 61);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(94, 29);
            this.codeButton.TabIndex = 7;
            this.codeButton.Text = "Koduj";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // ToCodeTextBox
            // 
            this.ToCodeTextBox.Location = new System.Drawing.Point(398, 13);
            this.ToCodeTextBox.Name = "ToCodeTextBox";
            this.ToCodeTextBox.Size = new System.Drawing.Size(235, 27);
            this.ToCodeTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wprowadź dane binarne:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TransmittedWordLabel);
            this.tabPage2.Controls.Add(this.TransmittedWordDescriptionLabel);
            this.tabPage2.Controls.Add(this.DecodedWordLabel);
            this.tabPage2.Controls.Add(this.DecodedWordDescriptionLabel);
            this.tabPage2.Controls.Add(this.DecodeInputTextBox);
            this.tabPage2.Controls.Add(this.ResultGroupBox);
            this.tabPage2.Controls.Add(this.decodeButton);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(867, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dekodowanie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TransmittedWordLabel
            // 
            this.TransmittedWordLabel.AutoSize = true;
            this.TransmittedWordLabel.Location = new System.Drawing.Point(365, 283);
            this.TransmittedWordLabel.Name = "TransmittedWordLabel";
            this.TransmittedWordLabel.Size = new System.Drawing.Size(50, 20);
            this.TransmittedWordLabel.TabIndex = 13;
            this.TransmittedWordLabel.Text = "label4";
            this.TransmittedWordLabel.Visible = false;
            // 
            // TransmittedWordDescriptionLabel
            // 
            this.TransmittedWordDescriptionLabel.AutoSize = true;
            this.TransmittedWordDescriptionLabel.Location = new System.Drawing.Point(216, 283);
            this.TransmittedWordDescriptionLabel.Name = "TransmittedWordDescriptionLabel";
            this.TransmittedWordDescriptionLabel.Size = new System.Drawing.Size(142, 20);
            this.TransmittedWordDescriptionLabel.TabIndex = 12;
            this.TransmittedWordDescriptionLabel.Text = "Słowo po transmisji:";
            this.TransmittedWordDescriptionLabel.Visible = false;
            // 
            // DecodedWordLabel
            // 
            this.DecodedWordLabel.AutoSize = true;
            this.DecodedWordLabel.Location = new System.Drawing.Point(465, 318);
            this.DecodedWordLabel.Name = "DecodedWordLabel";
            this.DecodedWordLabel.Size = new System.Drawing.Size(58, 20);
            this.DecodedWordLabel.TabIndex = 11;
            this.DecodedWordLabel.Text = "label15";
            this.DecodedWordLabel.Visible = false;
            // 
            // DecodedWordDescriptionLabel
            // 
            this.DecodedWordDescriptionLabel.AutoSize = true;
            this.DecodedWordDescriptionLabel.Location = new System.Drawing.Point(216, 318);
            this.DecodedWordDescriptionLabel.Name = "DecodedWordDescriptionLabel";
            this.DecodedWordDescriptionLabel.Size = new System.Drawing.Size(238, 20);
            this.DecodedWordDescriptionLabel.TabIndex = 10;
            this.DecodedWordDescriptionLabel.Text = "Poprawione i zdekodowane słowo:";
            this.DecodedWordDescriptionLabel.Visible = false;
            // 
            // DecodeInputTextBox
            // 
            this.DecodeInputTextBox.Location = new System.Drawing.Point(469, 11);
            this.DecodeInputTextBox.Name = "DecodeInputTextBox";
            this.DecodeInputTextBox.Size = new System.Drawing.Size(179, 27);
            this.DecodeInputTextBox.TabIndex = 9;
            // 
            // ResultGroupBox
            // 
            this.ResultGroupBox.Controls.Add(this.SyndromeLabel);
            this.ResultGroupBox.Controls.Add(this.NewControlBitsLabel);
            this.ResultGroupBox.Controls.Add(this.OriginalControlBitsLabel);
            this.ResultGroupBox.Controls.Add(this.label18);
            this.ResultGroupBox.Controls.Add(this.label17);
            this.ResultGroupBox.Controls.Add(this.label16);
            this.ResultGroupBox.Location = new System.Drawing.Point(211, 117);
            this.ResultGroupBox.Name = "ResultGroupBox";
            this.ResultGroupBox.Size = new System.Drawing.Size(369, 147);
            this.ResultGroupBox.TabIndex = 5;
            this.ResultGroupBox.TabStop = false;
            this.ResultGroupBox.Text = "Wynik";
            this.ResultGroupBox.Visible = false;
            // 
            // SyndromeLabel
            // 
            this.SyndromeLabel.AutoSize = true;
            this.SyndromeLabel.Location = new System.Drawing.Point(82, 92);
            this.SyndromeLabel.Name = "SyndromeLabel";
            this.SyndromeLabel.Size = new System.Drawing.Size(58, 20);
            this.SyndromeLabel.TabIndex = 9;
            this.SyndromeLabel.Text = "label10";
            // 
            // NewControlBitsLabel
            // 
            this.NewControlBitsLabel.AutoSize = true;
            this.NewControlBitsLabel.Location = new System.Drawing.Point(154, 67);
            this.NewControlBitsLabel.Name = "NewControlBitsLabel";
            this.NewControlBitsLabel.Size = new System.Drawing.Size(50, 20);
            this.NewControlBitsLabel.TabIndex = 8;
            this.NewControlBitsLabel.Text = "label4";
            // 
            // OriginalControlBitsLabel
            // 
            this.OriginalControlBitsLabel.AutoSize = true;
            this.OriginalControlBitsLabel.Location = new System.Drawing.Point(184, 45);
            this.OriginalControlBitsLabel.Name = "OriginalControlBitsLabel";
            this.OriginalControlBitsLabel.Size = new System.Drawing.Size(50, 20);
            this.OriginalControlBitsLabel.TabIndex = 7;
            this.OriginalControlBitsLabel.Text = "label3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Syndrom:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Nowe bity kontrolne:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(174, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Pierwotne bity kontrolne:";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(373, 65);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(94, 29);
            this.decodeButton.TabIndex = 4;
            this.decodeButton.Text = "Sprawdź";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Wprowadź słowo do sprawdzenia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Aplikacja do korekcji pojedynczego błędu za pomocą syndromu Hamminga";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ControlBitsGroupBox.ResumeLayout(false);
            this.ControlBitsGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResultGroupBox.ResumeLayout(false);
            this.ResultGroupBox.PerformLayout();
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
        private Button decodeButton;
        private Label label14;
        private GroupBox ResultGroupBox;
        private Label label18;
        private Label label17;
        private Label label16;
        private TabPage tabPage1;
        private Label CodedWordLabel;
        private Label CodedWordDescLabel;
        private GroupBox ControlBitsGroupBox;
        private Label C8Label;
        private Label C4Label;
        private Label C2Label;
        private Label C1Label;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Button codeButton;
        private TextBox ToCodeTextBox;
        private Label label1;
        private Label SyndromeLabel;
        private Label NewControlBitsLabel;
        private Label OriginalControlBitsLabel;
        private TextBox DecodeInputTextBox;
        private Label DecodedWordLabel;
        private Label DecodedWordDescriptionLabel;
        private Label TransmittedWordLabel;
        private Label TransmittedWordDescriptionLabel;
    }
}