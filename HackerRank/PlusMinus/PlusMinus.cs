using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace HackerRank.PlusMinus
{
    public class PlusMinusClass
    {
        public IList<string> Ratios { get; set; }
        public void PlusMinus(List<int> arr)
        {
            Ratios = new List<string>();
            var groupedItems = arr.Select(d => PositiveNegativeOrZero(d));
            var positiveRatio = (double)groupedItems.Where(d => d == 1).Count() / arr.Count;
            var negativeRatio = (double)groupedItems.Where(d => d == -1).Count() / arr.Count;
            var zeroRatio = (double)groupedItems.Where(d => d == 0).Count() / arr.Count;

            Ratios.Add(positiveRatio.ToString("0.000000"));
            Ratios.Add(negativeRatio.ToString("0.000000"));
            Ratios.Add(zeroRatio.ToString("0.000000"));
        }

        private int PositiveNegativeOrZero(int d)
        {
            if (d > 0)
                return 1;
            if (d < 0)
                return -1;            
            return 0;
        }
    }

    public class PlusMinusTest
    {
        private readonly PlusMinusClass _plusMinus;
        public PlusMinusTest()
        {
            _plusMinus = new PlusMinusClass();
        }

        [Fact]
        public void should_print_the_ratios_of_positive_negative_and_zero_elements_of_an_array()
        {
            var items = new List<int>()
            {
                1,
                1,
                0,
                -1,
                -1
            };

            _plusMinus.PlusMinus(items);

            _plusMinus.Ratios.ToArray()[0].Should().Be("0,400000");
            _plusMinus.Ratios.ToArray()[1].Should().Be("0,400000");
            _plusMinus.Ratios.ToArray()[2].Should().Be("0,200000");
        }
    }
}
