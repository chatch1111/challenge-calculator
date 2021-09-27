using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    public class Calculator
    {
        const int max = 1000;
        public Calculator() { }

        public string Add(string[] nums)
        {
            int temp = 0;
            int num = 0;
            /*bool hasNegatives = false;
            string exceptMessage = "";*/

            /*if (nums.Length > 2)
                throw new Exception("Too Many Numbers");*/

            for (int index = 0; index < nums.Length; ++index)
            {
                int.TryParse(nums[index], out num);

                if (num < max)
                {
                    temp += num;
                }

            }

            /*if (hasNegatives)
                throw new Exception("Negative Numbers Entered: " + exceptMessage);*/

            return temp.ToString();
        }
    }
}

/*
 * for(int index = 0; index < nums.Length; ++index)
            {
                int.TryParse(nums[index], out num);

                if(num < 0)
                {
                    hasNegatives = true;

                    exceptMessage += nums[index];

                    if (index < nums.Length)
                        exceptMessage += ",";
                }

                if(!hasNegatives)
                    temp += num;
            }
 */