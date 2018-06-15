using System;
using Xunit;
using Lab02UnitTestingATM;


namespace XUnitTest02Lab
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(500, 100, 400)]
        [InlineData(500, 600, 500)]
        public void WithdrawTest(double valueOne, double valueTwo, double valueReturned)
        {
            Assert.Equal(valueReturned, Program.WidthdrawMony(valueOne, valueTwo));
        }
    }

    public class UnitTest2
    {
        [Theory]
        [InlineData(100, 200, 300)]
        [InlineData(130, 0, 130)]
        public void DepositTest(double valueOne, double valueTwo, double valueReturned)
        {
            Assert.Equal(valueReturned, Program.DepositMoney(valueOne, valueTwo));
        }
    }

    
}
