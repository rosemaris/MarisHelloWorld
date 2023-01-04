using Computation.Mathematical.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computation.Mathematical
{
    public class AdditionService : IAdditionService
    {
        public int AddTwoNumbers(int number1, int number2)
        {
           var result = number1 + number2;

            return result;
        }
    }
}
