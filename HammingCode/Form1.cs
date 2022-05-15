using System.Text.RegularExpressions;

namespace HammingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            string input = ToCodeTextBox.Text;

            if (!Validate(input))
                return;

            bool[] bits = BinaryConverter.StringToBin(input);
            bool[] hammingCode = Hamming.ConvertToHamming(bits);

            ShowControlBits(input);

            string output = new(hammingCode.Select(x => x == true ? '1' : '0').ToArray());

            CodedWordLabel.Text = output;
            CorrectWordLabel.Text = output;
            CodedWordDescLabel.Visible = true;
        }

        private bool Validate(string input)
        {
            Regex regex = new("[^01]");

            if (input.Length != 8 || regex.IsMatch(input))
            {
                MessageBox.Show("Podaj 8-bitową liczbę binarną");
                return false;
            }

            return true;
        }

        private void ShowControlBits(string input)
        {
            bool[] bits = BinaryConverter.StringToBin(input);
            bool[] controlDigits = Hamming.CalculateControlBits(bits);

            string c1Text = $"{input[7]} xor {input[6]} xor {input[4]} xor {input[3]} xor {input[1]} = {controlDigits[0]}";
            string c2Text = $"{input[7]} xor {input[5]} xor {input[4]} xor {input[2]} xor {input[1]} = {controlDigits[1]}";
            string c4Text = $"{input[6]} xor {input[5]} xor {input[4]} xor {input[0]} = {controlDigits[2]}";
            string c8Text = $"{input[3]} xor {input[2]} xor {input[1]} xor {input[0]} = {controlDigits[3]}";

            C1Label.Text = c1Text;
            C2Label.Text = c2Text;
            C4Label.Text = c4Text;
            C8Label.Text = c8Text;
            ControlBitsGroupBox.Visible = true;
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            string word = CorrectWordLabel.Text;
            int indexToChange = 12 - (int)CorruptedBitNumber.Value;
            char valueToChange = word[indexToChange];
            char replacemnetValue = valueToChange == '1' ? '0' : '1';
            string input = word.Substring(0, 4) + word.Substring(5, 3) + word[9];
            string corruptedWord = word.Remove(indexToChange, 1).Insert(indexToChange, replacemnetValue.ToString());
            string corruptedInput = corruptedWord.Substring(0, 4) + corruptedWord.Substring(5, 3) + corruptedWord[9];
            bool[] bits = BinaryConverter.StringToBin(input);
            bool[] corruptedBits = BinaryConverter.StringToBin(corruptedInput);
            bool[] correctHammingCode = Hamming.ConvertToHamming(bits);
            bool[] corruptedHammingCode = Hamming.ConvertToHamming(corruptedBits);
            int syndrome = 0;
            syndrome += Convert.ToInt32(correctHammingCode[4] ^ corruptedHammingCode[4]) * 8;
            syndrome += Convert.ToInt32(correctHammingCode[8] ^ corruptedHammingCode[8]) * 4;
            syndrome += Convert.ToInt32(correctHammingCode[10] ^ corruptedHammingCode[10]) * 2;
            syndrome += Convert.ToInt32(correctHammingCode[11] ^ corruptedHammingCode[11]) * 1;
            char[] correctControlBits = correctHammingCode.Select(e => e == true ? '1' : '0').ToArray();
            char[] corruptedControlBits = corruptedHammingCode.Select(e => e == true ? '1' : '0').ToArray();
            label3.Text = correctControlBits[4].ToString() + correctControlBits[8] + correctControlBits[10] + correctControlBits[11];
            label4.Text = corruptedControlBits[4].ToString() + corruptedControlBits[8] + corruptedControlBits[10] + corruptedControlBits[11];
            label10.Text = syndrome.ToString();
            groupBox3.Visible = true;
        }
    }
}