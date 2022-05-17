

namespace HammingCode.Exceptions
{
    internal class TooManyMistakesException : Exception
    {
        public TooManyMistakesException() : base("Słowo zawiera zbyt wiele błędów do poprawienia")
        {
        }
    }
}
