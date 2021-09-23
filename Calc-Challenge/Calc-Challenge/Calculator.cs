using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    public class Calculator
    {
        public Calculator() { }

        public string Add(string[] nums)
        {
            int temp = 0;
            int num = 0;

            if (nums.Length > 2)
                throw new Exception("Too Many Numbers");

            for(int index = 0; index < nums.Length; ++index)
            {
                int.TryParse(nums[index], out num);
                temp += num;
            }

            return temp.ToString();
        }
    }
}
