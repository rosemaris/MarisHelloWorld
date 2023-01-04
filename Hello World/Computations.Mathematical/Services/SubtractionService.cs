using Computations.Mathematical.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical
{
    public class SubtractionService : ISubtractionService
    {
        public int SubtractionOfFourNumbers(int numb1, int numb2, int numb3, int numb4)
        {
            var difference = (numb1 - numb2) - (numb3 - numb4);
            return difference;
        }

        public int SubtractionOfThreeNumbers(int numb1, int numb2, int numb3)
        {
           var difference = (numb1 - numb2) - numb3;
            return difference;
        }

        public int SubtractionOfTwoNumbers(int numb1, int numb2)
        {
            var difference = (numb1 - numb2);
            return difference;
        }

        public object SubtractionOfThreeNumbers(int numb1, int numb2, object numb3)
        {
            throw new NotImplementedException();
        }
    }
}
