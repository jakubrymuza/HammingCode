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
            string input = CorrectWordLabel.Text;
            if (!Validate(input)) return;
            int indexToChange = (int)CorruptedBitNumber.Value - 1;
            char valueToChange = input[indexToChange];
            char replacemnetValue = valueToChange == '1' ? '0' : '1';
            string corruptedWord = input.Remove(indexToChange, 1).Insert(indexToChange, replacemnetValue.ToString());
            bool[] bits = BinaryConverter.StringToBin(input);
            bool[] hammingCode = Hamming.ConvertToHamming(bits);
        }
    }
}