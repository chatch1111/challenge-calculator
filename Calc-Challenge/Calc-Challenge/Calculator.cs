using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    public abstract class Calculator : ICustomSplit
    {
        const int max = 1000;
        public string Add(string[] nums)
        {
            int temp = 0;
            int num = 0;
            bool hasNegatives = false;
            string exceptMessage = "";

            for (int index = 0; index < nums.Length; ++index)
            {
                int.TryParse(nums[index], out num);

                if (num < 0)
                {
                    hasNegatives = true;

                    exceptMessage += nums[index];

                    if (index < nums.Length)
                        exceptMessage += ",";
                }
                else if (num < max)
                {
                    temp += num;
                }
                        
            }

            if (hasNegatives)
            {
                Console.WriteLine(temp.ToString());
                throw new Exception("Negative Numbers Entered: " + exceptMessage);
            }
                

            return temp.ToString();
        }

        public abstract string[] CustomSplit(string toSplit);
    }
}