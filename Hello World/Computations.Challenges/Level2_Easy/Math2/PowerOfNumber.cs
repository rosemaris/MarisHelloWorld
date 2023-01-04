using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * === To the Power of _____  ===
     
                Create a function that takes a base number and an exponent number and returns the calculation.

                Examples
                СalculateExponent(5, 5) ➞ 3125
                СalculateExponent(10, 10) ➞ 10000000000
                СalculateExponent(3, 3) ➞ 27

                Notes
                All test inputs will be positive integers.
                Don't forget to return the result.

     */
    public interface IPowerOfNumber
    {
        long Get(long number, long exponent);
    }
    public class PowerOfNumber : IPowerOfNumber
    {
        public long Get(long number, long exponent)
        {
            long result = 0;
            if (exponent != 0)
            {
                var powerOFExponent = Math.Pow(number, exponent);
                result = Convert.ToInt64(powerOFExponent);
            }
            return result;
        }
    }
    /* https://www.geeksforgeeks.org/c-sharp-math-pow-method/ */
}
