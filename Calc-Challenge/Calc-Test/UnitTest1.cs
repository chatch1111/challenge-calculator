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
            string testNums = "1,5000";
            string expected = "5001";

            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact (Skip = "not used")]
       
        public void TestAddNeg()
        {
            string testNums = "4,-3";
            string expected = "1";

            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact]
        public void TestAddSingle()
        {
            string testNums = "20";
            string expected = "20";

            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact]
        public void TestAddInvalid()
        {
            string testNums = "5,tyty";
            string expected = "5";

            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact]
        public void TestAddNoMax()
        {
            string testNums = "1,2,3,4,5,6,7,8,9,10,11,12";
            string expected = "78";

            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Add(testNums.Split(',')));
        }

        [Fact]
        public void TestAddNewLine()
        {
            string testNums = "1\n2,3";
            string expected = "6";

            var calculator = new Calculator();

            Assert.Equal(expected, calculator.Add(testNums.Split(
                new[] { "\r\n", "\r", "\n", "," },
                StringSplitOptions.None
            )));
        }
    }
}
