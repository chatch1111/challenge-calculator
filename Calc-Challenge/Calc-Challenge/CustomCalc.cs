using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    public class CustomCalc : Calculator, ICustomSplit
    {

        public CustomCalc() { }

        public override string[] CustomSplit(string toSplit)
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
    }
}
