using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * === Next Number Greater Than A and B and Divisible by B  ===
     
                 You are given two numbers a and b. Create a function that returns the next number greater than a and b and divisible by b.

                Examples
                DivisibleByB(17, 8) ➞ 24
                DivisibleByB(98, 3) ➞ 99
                DivisibleByB(14, 11) ➞ 22

                Notes
                a will always be greater than b.
     */
    public interface INextNumberGreaterThanAB
    {
        int Get(int a, int b);
    }
    public class NextNumberGreaterThanAB : INextNumberGreaterThanAB
    {
        public int Get(int a, int b)
        {
            if (a % b == 0)
                return a;
            if (b < 0)
                return 0;
            var NextNumber = (a / b);
            return NextNumber * b + b;
        }
    }
    /*https://upokary.com/find-next-higher-natural-number-that-is-divisble-by-another-number/ */
}
