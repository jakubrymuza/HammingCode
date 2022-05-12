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
            /*string input1 = textBox2.Text;
            string input2 = textBox3.Text;
            int diff = input1.Zip(input2, (x, y) => x == y).Count(z => !z); // liczba różniących się bitów w słowach wejściowych
            Regex regex = new("[^01]");
            if (input1.Length != 8 || regex.IsMatch(input1) || input2.Length != 8 || regex.IsMatch(input2))
            {
                MessageBox.Show("Podaj 8-bitową liczbę binarną");
                return;
            }
            if (diff != 1)
            {
                MessageBox.Show("Podane ciagi nie różnią się jednym bitem. Wyliczony syndrom nie pozwoli na korekcję błędów.", "Uwaga",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bool[] correctWord = input1.AsEnumerable().Select(x => x == '1').ToArray();
            bool[] incorrectWord = input2.AsEnumerable().Select(x => x == '1').ToArray();
            bool[] controlCorrect = CalculateControlBits(correctWord);
            bool[] controlIncorrect = CalculateControlBits(incorrectWord);

            int syndrome = 0;

            // liczenie syndromu - XOR po wszystkich bitach obu kod�w korekcyjnych
            for (int i = 0, p = 1; i < 4; i++, p <<= 1)
                syndrome += Convert.ToInt32(controlCorrect[i] ^ controlIncorrect[i]) * p;

            string oldControlBits = new(controlCorrect.AsEnumerable().Select(x => x == true ? '1' : '0').ToArray());
            string newControlBits = new(controlIncorrect.AsEnumerable().Select(x => x == true ? '1' : '0').ToArray());
            label3.Text = oldControlBits;
            label4.Text = newControlBits;
            label10.Text = PositionWithShift(syndrome).ToString();
            groupBox3.Visible = true;*/
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