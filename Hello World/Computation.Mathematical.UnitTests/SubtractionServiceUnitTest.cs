using Computations.Mathematical;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Computation.Mathematical.UnitTests
{
    public class SubtractionServiceUnitTest
    {
        
        [Fact]
        public void DifferenceOfTwoNumbers_ReturnTo4_WhenPassing10and6()
        {
            var subtractionService = new SubtractionService();
            int expected = 4;
            int numb1 = 10;
            int numb2 = 6;
            var difference2 = subtractionService.SubtractionOfTwoNumbers(numb1, numb2);
            Assert.Equal(expected, difference2);
        }

        [Fact]
        public void DifferenceOfThreeNumbers_ReturnT7_WhenPAssing20and10and3()
        {
            var subtractService = new SubtractionService();
            int expected = 7;
            int numb1 = 20;
            int numb2 = 10;
            int numb3 = 3;
            var difference3 = subtractService.SubtractionOfThreeNumbers(numb1,numb2,numb3);
            Assert.Equal(expected, difference3);
        }

        [Fact]
        public void DifferenceOfFourNumbers_ReturnTo2_WhenPAssing30and15and25and12()
        {
            var subtractionService = new SubtractionService();
            var expected = 2;
            int numb1 = 30;
            int numb2 = 15;
            int numb3 = 25;
            int numb4 = 12;
            var difference4 = subtractionService.SubtractionOfFourNumbers(numb1, numb2, numb3, numb4);
            Assert.Equal(expected, difference4);
        }
    }
}
