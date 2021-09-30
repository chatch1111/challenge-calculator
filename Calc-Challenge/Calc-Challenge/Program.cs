using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Calc_Challenge
{
    enum CalculatorType
    {
        Base,
        CustomDelim,
        CustomDelimNLength
    }

    public enum Operations : int
    {
        Add = 0,
        Subtract = 1,
        Divide = 2,
        Multiply = 3
    }
    class Program
    {      
        static void Main(string[] args)
        {

            Calculator calculator;
            string[] numbers;

            CalculatorType calculatorType = GetCalcType(args[0]);
            //CalculatorType calculatorType = GetCalcType("4,-3,-2");

            try
            {
                switch (calculatorType)
                {
                    case CalculatorType.CustomDelim:
                        calculator = new CustomCalc();
                        break;
                    case CalculatorType.CustomDelimNLength:
                        calculator = new CustomCalcNLengthNDelim();
                        break;
                    default:
                        calculator = new BaseCalc();
                        break;
                }

                numbers = calculator.CustomSplit(args[0]);
                //numbers = calculator.CustomSplit("4,-3,-2");

                Console.WriteLine(calculator.Operator(numbers, Operations.Add));
                Console.WriteLine(calculator.Operator(numbers, Operations.Subtract));
                Console.WriteLine(calculator.Operator(numbers, Operations.Divide));
                Console.WriteLine(calculator.Operator(numbers, Operations.Multiply));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static CalculatorType GetCalcType(string input)
        {

            var pattern = @"(?<=//).+?(?=\\n)";

            var regex = new Regex(pattern);

            var match = regex.Match(input);

            if(match.Success)
            {
                if(match.ToString().Length == 1)
                {
                    return CalculatorType.CustomDelim;
                }
                else
                {
                    return CalculatorType.CustomDelimNLength;
                }
            }

            return CalculatorType.Base;
        }
    }
}
