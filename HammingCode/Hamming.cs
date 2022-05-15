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
    }
}
