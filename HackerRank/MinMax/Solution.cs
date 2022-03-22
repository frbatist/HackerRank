using System.Collections.Generic;
using System.Linq;

namespace HackerRank.MinMax
{
    public class Solution
    {
        public string PrintedValue { get; set; }

        internal void miniMaxSum(List<int> arr)
        {
            var minValue = arr.OrderBy(d => d).Take(4).Sum();
            var maxValue = arr.OrderByDescending(d => d).Take(4).Sum();
            PrintedValue = $"{minValue} {maxValue}";
        }
    }
}
