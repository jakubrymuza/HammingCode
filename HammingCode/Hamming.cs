namespace HammingCode
{
    public static class Hamming
    {
        public static bool[] CalculateControlBits(bool[] word)
        {
            bool[] control = new bool[4]; // bity kontrolne C1 C2 C4 C8

            control[0] = word[0] ^ word[1] ^ word[3] ^ word[4] ^ word[6];
            control[1] = word[0] ^ word[2] ^ word[3] ^ word[5] ^ word[6];
            control[2] = word[1] ^ word[2] ^ word[3] ^ word[7];
            control[3] = word[4] ^ word[5] ^ word[6] ^ word[7];

            return control;
        }

        // funkcja obliczająca pozycje po przesunieciu ze względu na dodanie kodów korekcyjnych
        public static int PositionWithShift(int position)
        {
            if (position < 4) return position - 2;
            if (position < 8) return position - 3;
            return position - 4;
        }


        // funkcja koduje slowo za pomoca kodu hamminga
        public static bool[] ConvertToHamming(bool[] word)
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

        public static int CalculateSyndrome(bool[] inputBits, bool[] hammingCode)
        {
            int syndrome = 0;
            syndrome += Convert.ToInt32(inputBits[4] ^ hammingCode[4]) * 8;
            syndrome += Convert.ToInt32(inputBits[8] ^ hammingCode[8]) * 4;
            syndrome += Convert.ToInt32(inputBits[10] ^ hammingCode[10]) * 2;
            syndrome += Convert.ToInt32(inputBits[11] ^ hammingCode[11]) * 1;
            return syndrome;
        }

        public static string CorrectWrongBit(string input, int syndrome)
        {
            if (syndrome <= 0)
                return input;
            if (syndrome > 12)
                throw new Exceptions.TooManyMistakesException();

            int indexToChange = 12 - syndrome;
            char toChange = input[indexToChange];
            char replacement = toChange == '1' ? '0' : '1';
            return input.Remove(indexToChange, 1).Insert(indexToChange, replacement.ToString());
        }

        public static string RemoveControlBits(string word)
        {
            string result = word.Substring(0, 4) + word.Substring(5, 3) + word[9];
            return result;
        }

        public static string GetControlBits(string input) => input[4].ToString() + input[8] + input[10] + input[11];
    }
}
