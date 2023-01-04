using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy.Math
{
    /*
     * === Divides Evenly  ===
     
                Given two integers, a and b, return true if a can be divided evenly by b. Return false otherwise.

                Examples
                dividesEvenly(98, 7) ➞ true
                // 98/7 = 14
                dividesEvenly(85, 4) ➞ false
                // 85/4 = 21.25

                Notes
                a will always be greater than or equal to b.
     */

    public interface IDividesEvenly
    {
        bool IsDividedEvenly(int a, int b);
    }
    public class DividesEvenly : IDividesEvenly
    {
        public bool IsDividedEvenly(int a, int b)
        {
            var quotient = a % b;
            if (quotient ==0)
                return true;
            else
                return false;
        }
    }
}
