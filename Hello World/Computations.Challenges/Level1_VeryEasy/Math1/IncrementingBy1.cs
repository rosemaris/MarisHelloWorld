using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Return the Next Number from the Integer Passed  ===
     
                 Create a function that takes a number as an argument, increments the number by +1 and returns the result.

                Examples
                Addition(0) ➞ 1
                Addition(9) ➞ 10
                Addition(-3) ➞ -2

                Notes
                Don't forget to return the result.
     */
    public interface IIncrementingBy1
    {
        int Increase(int num);
    }
    public class IncrementingBy1 : IIncrementingBy1
    {
        public int Increase(int num)
        {
            var add = num + 1;
            return add;
        }
    }
}
