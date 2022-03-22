using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.TimeConversion
{
    public class Solution
    {
        internal string timeConversion(string input)
        {
            var datetime = DateTime.Parse(input);
            return datetime.ToString("HH:mm:ss");
        }
    }
}
