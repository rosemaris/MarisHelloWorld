using Computations.Mathematical.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical
{
    public class AverageService : IAverageService
    {
        public int AverageOfFourNumbers(int num1, int num2, int num3, int num4)
        {
           var average = (num1 + num2 + num3 + num4) / 4;
            return average;
        }

        public int AverageOfThreeNumbers(int num1, int num2, int num3)
        {
            var average = (num1 + num2 + num3 ) / 3;
            return average;
        }

        public int AverageOfTwoNumbers(int num1, int num2)
        {
            var average = (num1 + num2 ) / 2;
            return average;
        }
    }
}
