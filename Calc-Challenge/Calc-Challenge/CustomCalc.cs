using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    public class CustomCalc : Calculator, ICustomSplit
    {

        public CustomCalc() { }

        public string[] CustomSplit(string toSplit)
        {

            string[] tempVal = toSplit.Split(
                new[] { "\\n" },
                StringSplitOptions.None
            );

            string[] retVal = tempVal[1].Split(
                new[] { tempVal[0][2] },
                StringSplitOptions.None
            );

            return retVal;
        }

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

    }
}
