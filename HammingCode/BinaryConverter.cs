
namespace HammingCode
{
    public static class BinaryConverter
    {
        public static bool[] StringToBin(string input) => input.AsEnumerable().Select(x => x == '1').ToArray();
    }
}
