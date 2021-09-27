using System;

namespace Calc_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculator = new CustomCalcNLengthNDelim();
            string[] numbers;

            numbers = calculator.CustomSplit(args[0]);

            try
            {
                Console.WriteLine(calculator.Add(numbers));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
