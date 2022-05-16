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

        private bool ValidateDecode(string input)
        {
            Regex regex = new("[^01]");

            if (input.Length != 12 || regex.IsMatch(input))
            {
                MessageBox.Show("Podaj 12-bitową liczbę binarną");
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
            string input = DecodeInputTextBox.Text;
            if (!ValidateDecode(input)) return;
            string wordToCheck = input.Substring(0, 4) + input.Substring(5, 3) + input[9];
            bool[] inputBits = BinaryConverter.StringToBin(input);
            bool[] bits = BinaryConverter.StringToBin(wordToCheck);
            bool[] hammingCode = Hamming.ConvertToHamming(bits);
            int syndrome = 0;
            syndrome += Convert.ToInt32(inputBits[4] ^ hammingCode[4]) * 8;
            syndrome += Convert.ToInt32(inputBits[8] ^ hammingCode[8]) * 4;
            syndrome += Convert.ToInt32(inputBits[10] ^ hammingCode[10]) * 2;
            syndrome += Convert.ToInt32(inputBits[11] ^ hammingCode[11]) * 1;
            string originalControlBits = input[4].ToString() + input[8] + input[10] + input[11];
            string hammingCodeString = new(hammingCode.Select(e => e == true ? '1' : '0').ToArray());
            string newControlBits = hammingCodeString[4].ToString() + hammingCodeString[8] + hammingCodeString[10] + hammingCodeString[11];
            string correctedWord = CorrectWrongBit(hammingCodeString, syndrome);
            if (correctedWord == "BŁĄD") return;
            string decodedWord = correctedWord.Substring(0, 4) + correctedWord.Substring(5, 3) + correctedWord[9];
            OriginalControlBitsLabel.Text = originalControlBits;
            NewControlBitsLabel.Text = newControlBits;
            SyndromeLabel.Text = $"{Convert.ToString(syndrome, 2)} -> {syndrome}";
            ResultGroupBox.Visible = true;
            DecodedWordDescriptionLabel.Visible = true;
            DecodedWordLabel.Visible = true;
            DecodedWordLabel.Text = decodedWord;
        }

        private string CorrectWrongBit(string input, int syndrome)
        {
            if (syndrome <= 0) return input;
            if (syndrome > 12)
            {
                MessageBox.Show("To słowo zawierało więcej niż jeden błąd. Nie można zdekodować za pomocą syndromu Hamminga.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "BŁĄD";
            }
            int indexToChange = 12 - syndrome;
            char toChange = input[indexToChange];
            char replacement = toChange == '1' ? '0' : '1';
            return input.Remove(indexToChange, 1).Insert(indexToChange, replacement.ToString());
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}