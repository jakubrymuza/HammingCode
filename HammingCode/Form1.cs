using System.Text.RegularExpressions;

namespace HammingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Regex regex = new("[^01]");
            if (input.Length != 8 || regex.IsMatch(input))
            {
                MessageBox.Show("Podaj 8-bitową liczbę binarną");
                return;
            }
            bool[] bits = textBox1.Text.AsEnumerable().Select(x => x == '1').ToArray();
            bool[] hammingCode = ConvertToHamming(bits);
            string c1Text = $"{input[7]} xor {input[6]} xor {input[4]} xor {input[3]} xor {input[1]} = {hammingCode[11]}";
            string c2Text = $"{input[7]} xor {input[5]} xor {input[4]} xor {input[2]} xor {input[1]} = {hammingCode[10]}";
            string c4Text = $"{input[6]} xor {input[5]} xor {input[4]} xor {input[0]} = {hammingCode[8]}";
            string c8Text = $"{input[3]} xor {input[2]} xor {input[1]} xor {input[0]} = {hammingCode[4]}";
            string output = new (hammingCode.Select(x => x == true ? '1' : '0').ToArray());
            label20.Text = output;
            label21.Text = c1Text;
            label22.Text = c2Text;
            label23.Text = c4Text;
            label24.Text = c8Text;
            groupBox1.Visible = true;
            label8.Visible = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool[] CalculateControlBits(bool[] word)
        {
            bool[] control = new bool[4]; // bity kontrolne C1 C2 C4 C8

            control[0] = word[0] ^ word[1] ^ word[3] ^ word[4] ^ word[6];
            control[1] = word[0] ^ word[2] ^ word[3] ^ word[5] ^ word[6];
            control[2] = word[1] ^ word[2] ^ word[3] ^ word[7];
            control[3] = word[4] ^ word[5] ^ word[6] ^ word[7];

            return control;
        }

        // funkcja oblicza pozycj� po przesuni�ciu ze wzgl�du na dodanie kod�w korekcyjnych
        int PositionWithShift(int position)
        {
            if (position < 4) return position - 2;
            if (position < 8) return position - 3;
            return position - 4;
        }

        // funkcja szuka bitu na kt�rym wyst�puje b��d w s�owie
        int FindErrorPosition(bool[] correctWord, bool[] incorrectWord)
        {
            // kody korekcyjne odpowiednio dla poprawnego i nieporawnego s�owa
            bool[] controlCorrect = CalculateControlBits(correctWord);
            bool[] controlIncorrect = CalculateControlBits(incorrectWord);

            int syndrome = 0;

            // liczenie syndromu - XOR po wszystkich bitach obu kod�w korekcyjnych
            for (int i = 0, p = 1; i < 4; i++, p <<= 1)
                syndrome += Convert.ToInt32(controlCorrect[i] ^ controlIncorrect[i]) * p;

            return PositionWithShift(syndrome);
        }

        // t�umaczy pozycje bit�w danych ze s�owa pierwotnego na pozycje w kodzie hamminga
        int translatePosition(int position)
        {
            int offset = 0;
            if (position == 0) offset = 2;
            else if (position < 4) offset = 3;
            else offset = 4;

            return offset + position;
        }

        // funkcja koduje s�owo za pomoc� kodu hamminga
        bool[] ConvertToHamming(bool[] word)
        {
            bool[] hammingCode = new bool[12];
            bool[] controlBits = CalculateControlBits(word.Reverse().ToArray());
            hammingCode[11] = controlBits[0];
            hammingCode[10] = controlBits[1];
            hammingCode[8] = controlBits[2];
            hammingCode[4] = controlBits[3];
            hammingCode[0] = word[0];
            hammingCode[1] = word[1];
            hammingCode[2] = word[2];
            hammingCode[3] = word[3];
            hammingCode[5] = word[4];
            hammingCode[6] = word[5];
            hammingCode[7] = word[6];
            hammingCode[9] = word[7];
            return hammingCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input1 = textBox2.Text;
            string input2 = textBox3.Text;
            int diff = input1.Zip(input2, (x, y) => x == y).Count(z => !z); // liczba różniących się bitów w słowach wejściowych
            Regex regex = new("[^01]");
            if (input1.Length != 8 || regex.IsMatch(input1) || input2.Length != 8 || regex.IsMatch(input2))
            {
                MessageBox.Show("Podaj 8-bitową liczbę binarną");
                return;
            }
            if(diff != 1)
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
            groupBox3.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}