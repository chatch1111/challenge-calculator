using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calc_Challenge
{
    public class CustomCalcNDelim : Calculator, ICustomSplit
    {
        
        public CustomCalcNDelim() { }

        public override string Add(string[] input)
        {
            int num = 0;
            int temp = 0;

            for (int index = 0; index < input.Length; ++index)
            {
                int.TryParse(input[index], out num);

                temp += num;

            }

            return temp.ToString();
        }

        public string[] CustomSplit(string toSplit)
        {
            Regex regex = new Regex(@"(?<=\[).+?(?=\])", RegexOptions.IgnoreCase);

            Match match = regex.Match(toSplit);

            string[] tempVal = toSplit.Split(
                new[] { "\n" , "\\n" },
                StringSplitOptions.None
            );

            char[] matchStr = match.Value.ToCharArray();

            string[] retVal = tempVal[1].Split(
                matchStr,
                StringSplitOptions.None
            );

            return retVal;
        }
    }
}
