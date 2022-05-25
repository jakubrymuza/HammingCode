using HammingCode;
using Xunit;

namespace Test.DecodeTests
{

    public class Syndrome
    {
        [Fact]
        public void ValidSyndromeTestCase1()
        {
            int expectedSyndrome = 0;
            string inputBits = "101001011000";

            var _ = Hamming.Decode(inputBits, out int calculatedSyndrome, out string _, out string _, out string _);

            Assert.Equal(expectedSyndrome, calculatedSyndrome);
        }

        [Fact]
        public void ValidSyndromeTestCase2()
        {
            int expectedSyndrome = 10;
            string inputBits = "000011010111";

            var _ = Hamming.Decode(inputBits, out int calculatedSyndrome, out string _, out string _, out string _);

            Assert.Equal(expectedSyndrome, calculatedSyndrome);
        }

        [Fact]
        public void ValidSyndromeTestCase3()
        {
            int expectedSyndrome = 8;
            string inputBits = "101011011000";

            var _ = Hamming.Decode(inputBits, out int calculatedSyndrome, out string _, out string _, out string _);

            Assert.Equal(expectedSyndrome, calculatedSyndrome);
        }
    }
}
