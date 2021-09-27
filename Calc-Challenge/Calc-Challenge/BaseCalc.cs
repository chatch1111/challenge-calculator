using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    class BaseCalc : Calculator, ICustomSplit
    {

        public override string[] CustomSplit(string toSplit)
        {
            string[] numbers = toSplit.Split(
                new[] { "\n", "\\n", "," },
                StringSplitOptions.None
            );

            return numbers;
        }
    }

}
