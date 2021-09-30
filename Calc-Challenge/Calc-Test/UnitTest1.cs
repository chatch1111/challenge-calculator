using System;
using Xunit;
using Calc_Challenge;

namespace Calc_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            var testNums = "1,5000";
            var expected = "1";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(','), Operations.Add));
        }

        [Fact]
       
        public void TestAddNeg()
        {
            var testNums = "4,-3";
            var expected = "1";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(','), Operations.Add));
        }

        [Fact]
        public void TestAddSingle()
        {
            var testNums = "20";
            var expected = "20";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(','), Operations.Add));
        }

        [Fact]
        public void TestAddInvalid()
        {
            var testNums = "5,tyty";
            var expected = "5";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(','), Operations.Add));
        }

        [Fact]
        public void TestAddNoMax()
        {
            var testNums = "1,2,3,4,5,6,7,8,9,10,11,12";
            var expected = "78";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(','), Operations.Add));
        }

        [Fact]
        public void TestAddNewLine()
        {
            var testNums = "1\n2,3";
            var expected = "6";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(
                new[] { "\r\n", "\r", "\n", "," },
                StringSplitOptions.None
            ), Operations.Add));
        }

        [Fact]
        public void TestAddLimited()
        {
            var testNums = "2,1001,6";
            var expected = "8";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(testNums.Split(','), Operations.Add));
        }

        [Fact]
        public void TestAddCustomDelim()
        {
            var testNums = "//#\n2#5";
            var expected = "7";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(calculator.CustomSplit(testNums), Operations.Add));
        }

        [Fact]
        public void TestAddCustomDelim1()
        {
            var testNums = "//,\n2,ff,100";
            var expected = "102";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Operator(calculator.CustomSplit(testNums), Operations.Add));
        }

        [Fact]
        public void TestAddCustomDelimNLength()
        {
            var testNums = "//[***]\n11***22***33";
            var expected = "66";

            var calculator = new CustomCalcNLengthNDelim();

            Assert.Equal(expected, calculator.Operator(calculator.CustomSplit(testNums), Operations.Add));
        }

        [Fact]
        public void TestAddCustomDelimNLengthNDelim()
        {
            var testNums = "//[*][!!][r9r]\n11r9r22*hh*33!!44";
            var expected = "110";

            var calculator = new CustomCalcNLengthNDelim();

            Assert.Equal(expected, calculator.Operator(calculator.CustomSplit(testNums), Operations.Add));
        }


    }
}
