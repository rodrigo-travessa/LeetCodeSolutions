using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    public class CountingBits
    {
        [Theory]
        [InlineData(1,1)]
        [InlineData(2, 1)]
        [InlineData(5, 2)]
        [InlineData(8, 1)]
        [InlineData(265, 3)]
        public void Test1(int entry, int result)
        {
            NumberOf1Bits numberOf1Bits = new NumberOf1Bits();
            Assert.Equal(result, numberOf1Bits.HammingWeight(Convert.ToUInt32(entry)));
            Assert.Equal(result, numberOf1Bits.HammingWeight2(Convert.ToUInt32(entry)));
        }
    }
}
