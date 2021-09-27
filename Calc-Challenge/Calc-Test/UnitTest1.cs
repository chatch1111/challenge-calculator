using System;
using Xunit;
using Calc_Challenge;

namespace Calc_Test
{
    public class UnitTest1
    {
        [Fact (Skip = "not used")]
        public void TestAdd()
        {
            string testNums = "1,5000";
            string expected = "5001";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact (Skip = "not used")]
       
        public void TestAddNeg()
        {
            string testNums = "4,-3";
            string expected = "1";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact (Skip = "not used")]
        public void TestAddSingle()
        {
            string testNums = "20";
            string expected = "20";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact(Skip = "not used")]
        public void TestAddInvalid()
        {
            string testNums = "5,tyty";
            string expected = "5";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact (Skip = "not used")]
        public void TestAddNoMax()
        {
            string testNums = "1,2,3,4,5,6,7,8,9,10,11,12";
            string expected = "78";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact (Skip = "not used")]
        public void TestAddNewLine()
        {
            string testNums = "1\n2,3";
            string expected = "6";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(
                new[] { "\r\n", "\r", "\n", "," },
                StringSplitOptions.None
            )));
        }

        [Fact (Skip = "not used")]
        public void TestAddLimited()
        {
            string testNums = "2,1001,6";
            string expected = "8";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact]
        public void TestAddCustomDelim()
        {
            string testNums = "//#\n2#5";
            string expected = "7";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(calculator.CustomSplit(testNums)));
        }

        [Fact]
        public void TestAddCustomDelim1()
        {
            string testNums = "//,\n2,ff,100";
            string expected = "102";

            var calculator = new CustomCalc();

            Assert.Equal(expected, calculator.Add(calculator.CustomSplit(testNums)));
        }
    }
}
