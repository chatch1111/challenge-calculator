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

        [Fact]
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
    }
}
