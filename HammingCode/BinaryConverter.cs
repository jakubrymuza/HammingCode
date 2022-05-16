
namespace HammingCode
{
    public static class BinaryConverter
    {
        public static bool[] StringToBin(string input) => input.AsEnumerable().Select(x => x == '1').ToArray();

        public static string BinToString(bool[] word) => new(word.Select(e => e == true ? '1' : '0').ToArray());
    }
}
