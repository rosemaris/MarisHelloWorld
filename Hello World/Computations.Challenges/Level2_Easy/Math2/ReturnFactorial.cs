using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     *===  Return the Factorial === 
     
                     Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.

                    Examples
                    Factorial(3) ➞ 6
                    Factorial(5) ➞ 120
                    Factorial(12) ➞ 479001600

                    Notes
                    Assume all inputs are greater than or equal to 0.
     */

    public interface IReturnFactorial
    {
        int Get(int num);
    }
    public class ReturnFactorial : IReturnFactorial
    {
        public int Get(int num)
        {
            int factorial = 1;
            for (int index = 1; index <= num; index++)
            {
                factorial *=  index;
            }
            return factorial;
        }
    }

    /* https://dotnettutorials.net/lesson/factorial-program-in-csharp/  */
}
