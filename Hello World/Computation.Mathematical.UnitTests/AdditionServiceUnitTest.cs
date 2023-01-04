using Computations.Mathematical;
using System;
using Xunit;

namespace Computation.Mathematical.UnitTests
{
    public class AdditionServiceUnitTest
    {

        [Fact]
        public void AddTwoNumbers_ShouldReturn5_WhenPassing3And2()
        {
            var additionService = new AdditionService();
            int expected = 5;

            int number1 = 3;
            int number2 = 2;

            int sum2 = additionService.AddTwoNumbers(number1, number2);
            Assert.Equal(expected, sum2);
        }

        [Fact]
        public void AddThreeNumbers_ShouldReturn10_WhenPassing2and3and5()
        {
            var additionService = new AdditionService();
            int expected = 10;

            int number1 = 2;
            int number2 = 3;
            int number3 = 5;

            int sum3 = additionService.AddThreeNumbers(number1, number2, number3);
            Assert.Equal(expected, sum3);
        }

        [Fact]
        public void AddFourNumbers_ShouldReturn20_WhenPassing4and3and5and8()
        {
            var additionService = new AdditionService();
            int expected = 20;
            int number1 = 4;
            int number2 = 3;
            int number3 = 5;
            int number4 = 8;

            int sum4 = additionService.AddFourNumbers(number1, number2, number3, number4);
            Assert.Equal(expected, sum4);
        }
    }
}
