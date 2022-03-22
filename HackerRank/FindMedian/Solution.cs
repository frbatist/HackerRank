using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace HackerRank.FindMedian
{
    public class Solution
    {
        internal int findMedian(List<int> arr)
        {
            var sideValue = (arr.Count - 1) / 2;
            return arr.OrderBy(d => d).ToArray()[sideValue];
        }
    }

    public class FindMedianTest
    {
        private readonly Solution _solution;
        public FindMedianTest()
        {
            _solution = new Solution();
        }

        [Fact]
        public void should_find_the_median()
        {
            var arr = new List<int> { 5, 3, 1, 2, 4 };

            int result = _solution.findMedian(arr);

            result.Should().Be(3);
        }
    }
}
