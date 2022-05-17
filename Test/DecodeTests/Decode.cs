using HammingCode;
using Xunit;

namespace Test.DecodeTests
{

    public class Decode
    {
        [Fact]
        public void ValidDecodeWithoutMistakesTestCase1()
        {
            string expectedBits = "10101010";
            string inputBits = "101001011000";

            var calculatedBits = Hamming.Decode(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidDecodeWithoutMistakesTestCase2()
        {
            string expectedBits = "00101011";
            string inputBits = "001011010111";

            var calculatedBits = Hamming.Decode(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidDecodeWithoutMistakesTestCase3()
        {
            string expectedBits = "11111111";
            string inputBits = "111101110111";

            var calculatedBits = Hamming.Decode(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidDecodeWithMistakesTestCase1()
        {
            string expectedBits = "10101010";
            string inputBits = "101011011000";

            var calculatedBits = Hamming.Decode(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidDecodeWithMistakesTestCase2()
        {
            string expectedBits = "00101011";
            string inputBits = "000011010111";

            var calculatedBits = Hamming.Decode(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidDecodeWithMistakesTestCase3()
        {
            string expectedBits = "11111111";
            string inputBits = "110101110111";

            var calculatedBits = Hamming.Decode(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }


    }
}
