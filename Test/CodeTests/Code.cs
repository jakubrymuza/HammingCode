using Xunit;
using HammingCode;

namespace Test.CodeTests
{

    public class Code
    {
        [Fact]
        public void ValidCodeTestCase1()
        {
            var inputBits = BinaryConverter.StringToBin("10101010");
            var expectedBits = BinaryConverter.StringToBin("101001011000");

            var calculatedBits = Hamming.ConvertToHamming(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidCodeTestCase2()
        {
            var inputBits = BinaryConverter.StringToBin("00101011");
            var expectedBits = BinaryConverter.StringToBin("001011010111");

            var calculatedBits = Hamming.ConvertToHamming(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }

        [Fact]
        public void ValidCodeTestCase3()
        {
            var inputBits = BinaryConverter.StringToBin("11111111");
            var expectedBits = BinaryConverter.StringToBin("111101110111");

            var calculatedBits = Hamming.ConvertToHamming(inputBits);

            Assert.Equal(expectedBits, calculatedBits);
        }
    }
}
