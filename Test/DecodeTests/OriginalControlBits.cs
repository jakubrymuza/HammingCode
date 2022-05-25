using HammingCode;
using Xunit;

namespace Test.DecodeTests
{

    public class OriginalControlBits
    {
        [Fact]
        public void ValidOriginalControlBitsTestCase1()
        {
            string expectedOriginalControlBits = "0100";
            string inputBits = "101001011000";

            var _ = Hamming.Decode(inputBits, out int _, out string calculatedOriginalControlBits, out string _, out string _);

            Assert.Equal(expectedOriginalControlBits, calculatedOriginalControlBits);
        }

        [Fact]
        public void ValidOriginalControlBitsTestCase2()
        {
            string expectedOriginalControlBits = "1011";
            string inputBits = "000011010111";

            var _ = Hamming.Decode(inputBits, out int _, out string calculatedOriginalControlBits, out string _, out string _);

            Assert.Equal(expectedOriginalControlBits, calculatedOriginalControlBits);
        }

        [Fact]
        public void ValidOriginalControlBitsTestCase3()
        {
            string expectedOriginalControlBits = "1100";
            string inputBits = "101011011000";

            var _ = Hamming.Decode(inputBits, out int _, out string calculatedOriginalControlBits, out string _, out string _);

            Assert.Equal(expectedOriginalControlBits, calculatedOriginalControlBits);
        }
    }
}
