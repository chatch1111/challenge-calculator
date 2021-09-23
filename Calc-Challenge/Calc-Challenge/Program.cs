using System;

namespace Calc_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = args[0].Split(',');

            var calculator = new Calculator();

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
