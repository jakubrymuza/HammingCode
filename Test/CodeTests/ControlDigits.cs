using HammingCode;
using Xunit;

namespace Test.CodeTests
{

    public class ControlDigits
    {
        [Fact]
        public void ValidControlDigitsTestCase1()
        {
            var inputBits = BinaryConverter.StringToBin("10101010");
            var expectedControlBits = BinaryConverter.StringToBin("1110");

            var calculatedControlBits = Hamming.CalculateControlBits(inputBits);

            Assert.Equal(expectedControlBits, calculatedControlBits);
        }

        [Fact]
        public void ValidControlDigitsTestCase2()
        {
            var inputBits = BinaryConverter.StringToBin("00101011");
            var expectedControlBits = BinaryConverter.StringToBin("0001");

            var calculatedControlBits = Hamming.CalculateControlBits(inputBits);

            Assert.Equal(expectedControlBits, calculatedControlBits);
        }

        [Fact]
        public void ValidControlDigitsTestCase3()
        {
            var inputBits = BinaryConverter.StringToBin("11111111");
            var expectedControlBits = BinaryConverter.StringToBin("1100");

            var calculatedControlBits = Hamming.CalculateControlBits(inputBits);

            Assert.Equal(expectedControlBits, calculatedControlBits);
        }
    }
}
