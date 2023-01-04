using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical.Interface
{
    internal interface IAverageService
    {
        int AverageOfTwoNumbers(int num1, int num2);
        int AverageOfThreeNumbers(int num1, int num2, int num3);
        int AverageOfFourNumbers(int num1, int num2, int num3, int num4);
    }
}
