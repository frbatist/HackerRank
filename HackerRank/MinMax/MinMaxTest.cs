using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace HackerRank.MinMax
{
    public class MinMaxTest 
    {
        private readonly Solution _solution;
        public MinMaxTest()
        {
            _solution = new Solution();
        }

        [Fact]
        public void should_print_min_and_max_values()
        {
            var arr = new List<int> { 1, 3, 5, 7, 9 };

            _solution.miniMaxSum(arr);

            _solution.PrintedValue.Should().Be("16 24");
        }
    }
}
