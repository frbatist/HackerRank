using FluentAssertions;
using Xunit;

namespace HackerRank.TimeConversion
{
    public class TimeConversionTest
    {
        private readonly Solution _solution;
        public TimeConversionTest()
        {
            _solution = new Solution();
        }

        [Theory]
        [InlineData("12:01:00PM", "12:01:00")]
        [InlineData("12:01:00AM", "00:01:00")]
        public void should_return_24_hours_based_date_time(string input, string output)
        {
            var converted = _solution.timeConversion(input);

            converted.Should().Be(output);
        }
    }
}
