using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calc_Challenge
{
    class Program
    {

        enum Calculators
        {
            Base,
            CustomDelim,
            CustomDelimNLength
        }

        

        static void Main(string[] args)
        {

            Calculator calculator;
            string[] numbers;


            Calculators calc = getCalcType(args[0]);
            //Calculators calc = getCalcType("//[***]\n11***22***33");

            try
            {
                switch (calc)
                {
                    case Calculators.CustomDelim:
                        calculator = new CustomCalc();
                        break;
                    case Calculators.CustomDelimNLength:
                        calculator = new CustomCalcNLengthNDelim();
                        break;
                    default:
                        calculator = new BaseCalc();
                        break;
                }

                numbers = calculator.CustomSplit(args[0]);
                //numbers = calculator.CustomSplit("//[***]\n11***22***33");

                Console.WriteLine(calculator.Add(numbers));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static Calculators getCalcType(string input)
        {

            string pattern = @"(?<=//).+?(?=\\n)";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

            if(match.Success)
            {
                if(match.ToString().Length == 1)
                {
                    return Calculators.CustomDelim;
                }
                else
                {
                    return Calculators.CustomDelimNLength;
                }
            }

            return Calculators.Base;
        }
    }
}
