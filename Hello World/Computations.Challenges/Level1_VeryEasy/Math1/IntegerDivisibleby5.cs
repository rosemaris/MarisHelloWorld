using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Check if an Integer is Divisible By Five  ===
     
                Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.

                Examples
                divisibleByFive(5) ➞ true
                divisibleByFive(-55) ➞ true
                divisibleByFive(37) ➞ false

                Notes
                Don't forget to return the result.
     */
    public interface IIntegerDivisibleby5
    {
        bool IsDivisibleByFive(int n);
    }
    public class IntegerDivisibleby5 : IIntegerDivisibleby5
    {
        public bool IsDivisibleByFive(int n)
        {
            var num = n % 5;
            if (num == 0)
            return true;
            else
                return false;
        }
    }
}
