using System.Text.RegularExpressions;

namespace HammingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncodeButtonClick(object sender, EventArgs e)
        {
            string input = txtEncode.Text;
            Regex regex = new("[^01]");
            if (input.Length != 8 || regex.IsMatch(input))
            {
                MessageBox.Show("Podaj 8-bitową liczbę binarną");
                return;
            }
            bool[] bits = txtEncode.Text.AsEnumerable().Select(x => x == '1').ToArray();
            bool[] hammingCode = HammingCoder.ConvertToHamming(bits);
            SetUITexts(input, hammingCode);
            groupControlBits.Visible = true;
            lblEncodedWordText.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string correctWord = lblCorrectWord.Text;
            int wrongBit = (int)numericUpDown1.Value;
            char wrongChar = correctWord[wrongBit - 1];
            string wrongWord = correctWord.Remove(wrongBit - 1, 1).Insert(wrongBit - 1, wrongChar == '1' ? "0" : "1");
            string controlBits = correctWord[4].ToString() + correctWord[8] + correctWord[10] + correctWord[11];
            
            string actualWord = correctWord.Substring(0, 4) + correctWord.Substring(5, 3) + correctWord[9];
            string actualWrongWord = wrongWord.Substring(0, 4) + wrongWord.Substring(5, 3) + wrongWord[9];
            bool[] wrongWordHammingCode = HammingCoder.ConvertToHamming(actualWrongWord.AsEnumerable().Select(x => x == '1').ToArray());
            string wrongWordHammingCodeText = new(wrongWordHammingCode.Select(x => x == true ? '1' : '0').ToArray());
            string wrongWordControlBits = wrongWordHammingCodeText[4].ToString() + wrongWordHammingCodeText[8] + wrongWordHammingCodeText[10] + wrongWordHammingCodeText[11];

            bool[] controlCorrect = controlBits.AsEnumerable().Select(x => x == '1').ToArray();
            bool[] controlIncorrect = wrongWordControlBits.AsEnumerable().Select(x => x == '1').ToArray();

            int syndrome = 0;

            // liczenie syndromu - XOR po wszystkich bitach obu kod�w korekcyjnych
            for (int i = 0, p = 8; i < 4; i++, p >>= 1)
                syndrome += Convert.ToInt32(controlCorrect[i] ^ controlIncorrect[i]) * p;

            //syndrome = HammingCoder.PositionWithShift(syndrome);

            //xorResult = HammingCoder.PositionWithShift(xorResult);

            label10.Text = syndrome.ToString();
            label3.Text = controlBits;
            label4.Text = wrongWordControlBits;
            groupResult.Visible = true;

        }

        void SetUITexts(string input, bool[] hammingCode)
        {
            string c1Text = $"{input[7]} xor {input[6]} xor {input[4]} xor {input[3]} xor {input[1]} = {hammingCode[11]}";
            string c2Text = $"{input[7]} xor {input[5]} xor {input[4]} xor {input[2]} xor {input[1]} = {hammingCode[10]}";
            string c4Text = $"{input[6]} xor {input[5]} xor {input[4]} xor {input[0]} = {hammingCode[8]}";
            string c8Text = $"{input[3]} xor {input[2]} xor {input[1]} xor {input[0]} = {hammingCode[4]}";
            string output = new(hammingCode.Select(x => x == true ? '1' : '0').ToArray());
            lblEncodedWord.Text = output;
            lblC1.Text = c1Text;
            lblC2.Text = c2Text;
            lblC4.Text = c4Text;
            lblC8.Text = c8Text;
            lblCorrectWord.Text = output;
            btnDecode.Enabled = true;
        }
    }
}