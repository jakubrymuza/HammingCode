using HammingCode;
using Xunit;

namespace Test.DecodeTests
{

    public class NewControlBits
    {
        [Fact]
        public void ValidOriginalControlBitsTestCase1()
        {
            string expectedNewControlBits = "0100";
            string inputBits = "101001011000";

            var _ = Hamming.Decode(inputBits, out int _, out string _, out string calculatedNewControlBits, out string _);

            Assert.Equal(expectedNewControlBits, calculatedNewControlBits);
        }

        [Fact]
        public void ValidOriginalControlBitsTestCase2()
        {
            string expectedNewControlBits = "0001";
            string inputBits = "000011010111";

            var _ = Hamming.Decode(inputBits, out int _, out string _, out string calculatedNewControlBits, out string _);

            Assert.Equal(expectedNewControlBits, calculatedNewControlBits);
        }

        [Fact]
        public void ValidOriginalControlBitsTestCase3()
        {
            string expectedNewControlBits = "0100";
            string inputBits = "101011011000";

            var _ = Hamming.Decode(inputBits, out int _, out string _, out string calculatedNewControlBits, out string _);

            Assert.Equal(expectedNewControlBits, calculatedNewControlBits);
        }
    }
}
