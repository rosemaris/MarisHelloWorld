using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical.Interface
{
    internal interface ISubtractionService
    {
        int SubtractionOfTwoNumbers(int numb1, int numb2);
        int SubtractionOfThreeNumbers(int numb1, int numb2, int numb3);
        int SubtractionOfFourNumbers(int numb1, int numb2, int numb3, int numb4);
    }
}
