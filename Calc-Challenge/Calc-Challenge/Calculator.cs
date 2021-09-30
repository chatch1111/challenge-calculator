using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Challenge
{
    public abstract class Calculator : ICustomSplit
    {
        string exceptMessage = "";
        bool hasNegatives = false;
        const int max = 1000;
        public string Operator(string[] nums, Operations op)
        {
            double temp = 0.0;
            double num = 0.0;
            string formula = BuildFormula(nums, op);


            for (int index = 0; index < nums.Length; ++index)
            {

                double.TryParse(nums[index], out num);

                if (num < 0)
                {
                    hasNegatives = false;

                    exceptMessage = BuildExceptMessage(index, nums.Length, (int)num);
                }
                else if (num < max)
                {

                    if(temp == 0.0 && index == 0)
                    {
                        temp = num;
                    }
                    else
                    {
                        temp = GetValue(op, temp, num);
                    }
                    
                }

            }

            formula += temp;

            if (hasNegatives)
            {
                Console.WriteLine(formula);
                throw new Exception("Negative Numbers Entered: " + exceptMessage);
            }


            return formula;
        }

        double GetValue(Operations op, double lhs, double rhs)
        {
            switch (op)
            {
                case Operations.Add:
                    return lhs += rhs;

                case Operations.Subtract:
                    return lhs -= rhs;

                case Operations.Divide:
                    return lhs /= rhs;

                case Operations.Multiply:
                    return lhs *= rhs;
                    
                default:
                    break;
            }

            return 0;
        }

        string BuildExceptMessage(int index, int length, int num)
        {
            var tmpMessage = exceptMessage;

            if (index < length)
            {
                if (tmpMessage.Equals(""))
                {
                    tmpMessage += num;
                }
                else
                {
                    tmpMessage += "," + num;
                }
            }

            return tmpMessage;
        }

        string BuildFormula(string[] nums, Operations op)
        {
            var tmpFormula = "";
            var tmpOp = GetOp(op);
            double num = 0.0;

            for (int index = 0; index < nums.Length; ++index)
            {

                if (index < nums.Length)
                {
                    num = CheckValue(nums[index]);

                    if (num > max)
                        num = 0;

                    if (tmpFormula.Equals(""))
                    {
                        tmpFormula += num;
                    }
                    else
                    {
                        tmpFormula += tmpOp + num;
                    }
                }

            }

            tmpFormula += " = ";

            return tmpFormula;
        }

        string GetOp(Operations op)
        {
            string[] opStrings = { "+", "-", "/", "*" };

            switch (op)
            {
                case Operations.Subtract:
                    return opStrings[(int)Operations.Subtract];

                case Operations.Divide:
                    return opStrings[(int)Operations.Divide];

                case Operations.Multiply:
                    return opStrings[(int)Operations.Multiply];
            }

            return opStrings[(int)Operations.Add];
        }

        double CheckValue(string input)
        {
            double num = 0.0;

            double.TryParse(input, out num);

            return num;
        }

        public abstract string[] CustomSplit(string toSplit);
    }
}