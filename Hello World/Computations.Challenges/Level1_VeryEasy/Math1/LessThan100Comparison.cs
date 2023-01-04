using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * ===  Less Than 100? ===
     
                Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.

                Examples
                lessThan100(22, 15) ➞ true
                // 22 + 15 = 37
                lessThan100(83, 34) ➞ false
                // 83 + 34 = 117
                lessThan100(3, 77) ➞ true
           
     */
    public interface ILessThan100Comparison
    {
        bool IsLessThan100(int a, int b);
    }
    public class LessThan100Comparison : ILessThan100Comparison
    {
        public bool IsLessThan100(int a, int b)
        {
            var sum = a + b;
            if (sum < 100)
                return true;
            else
                return false;
        }
    }
}
