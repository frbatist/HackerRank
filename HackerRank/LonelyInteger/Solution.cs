using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HackerRank.LonelyInteger
{
    internal class Solution
    {
        internal int lonelyinteger(List<int> arr)
        {
            return arr.GroupBy(d => d).Where(d => d.Count() == 1).FirstOrDefault().Key;
        }
    }

    public class LonelyIntegerTest
    {
        private readonly Solution _solution;
        public LonelyIntegerTest()
        {
            _solution = new Solution();
        }

        [Fact]
        public void should_return_the_lonely_int_value()
        {
            var arr = new List<int> { 1, 2, 3, 4, 3, 2, 1 };

            int lonelyInteger = _solution.lonelyinteger(arr);

            lonelyInteger.Should().Be(4);
        }
    }
}
