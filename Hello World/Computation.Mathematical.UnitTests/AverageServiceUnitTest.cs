using Computations.Mathematical;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Computation.Mathematical.UnitTests
{
    public class AverageServiceUnitTest

    {

        [Fact]
        public void AverageOfTwoNumbers_ShouldReturnTo5_WhenPAssing8and2()
        {
            var averageService = new AverageService();
            int expected = 5;
            int num1 = 8;
            int num2 = 2;
            int average2 = averageService.AverageOfTwoNumbers(num1, num2);
            Assert.Equal(expected, average2);
        }

        [Fact]
        public void AverageOfThreeNumbers_ShouldReturnTo6_WhenPassing6and5and7()
        {
            var averageService = new AverageService();
            var expected = 6;
            int num1 = 6;
            int num2 = 5;
            int num3 = 7;

            int average3 = averageService.AverageOfThreeNumbers(num1, num2, num3);
            Assert.Equal(expected, average3);
        }

        [Fact]
        public void AverageOfFourNumbers_ShoukdReturnTo4_WhenPassing5and6and3and2()
        {
            var averageService = new AverageService();
            int expected = 4;
            int num1 = 5;
            int num2 = 6;
            int num3= 3;
            int num4 = 2;
            var average4 = averageService.AverageOfFourNumbers(num1, num2, num3, num4);
            Assert.Equal(expected, average4);
        }




    }
}
