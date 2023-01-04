using Computations.Mathematical.Interface;
using System;

namespace Computations.Mathematical
{
    public class AdditionService : IAdditionService
    {
        public int AddFourNumbers(int number1, int number2, int number3, int number4)
        {
           var sum = number1 + number2 + number3 + number4;
            return sum;
        }
        
        public int AddThreeNumbers(int number1, int number2, int number3)
        {
            var sum = number1 + number2 + number3 ;
            return sum;
        }

        public int AddTwoNumbers(int number1, int number2)
        {
           var sum = number1 + number2;
          
            return sum; 
        }
    }
}
