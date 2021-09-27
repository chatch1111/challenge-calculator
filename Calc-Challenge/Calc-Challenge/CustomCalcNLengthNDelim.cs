using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calc_Challenge
{
    public class CustomCalcNLengthNDelim : Calculator, ICustomSplit
    {

        public CustomCalcNLengthNDelim() { }

        public override string[] CustomSplit(string toSplit)
        {
            string[] arr = Regex.Matches(toSplit, @"(?<=\[).+?(?=\])")
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();

            string[] tempVal = toSplit.Split(
                new[] { "\n", "\\n" },
                StringSplitOptions.None
            );

            string[] retVal = tempVal[1].Split(
                arr,
                StringSplitOptions.None
            );

            return retVal;
        }
    }
}
