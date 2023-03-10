using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Return the Remainder from Two Numbers===
     
                There is a single operator in C#, capable of providing the remainder of a division operation. Two numbers are passed as parameters. The first parameter divided by the second parameter will have a remainder, possibly zero. Return that value.

                Examples
                Remainder(1, 3) ➞ 1
                Remainder(3, 4) ➞ 3
                Remainder(-9, 45) ➞ -9
                Remainder(5, 5) ➞ 0

                Notes
                The tests only use positive and negative integers.
                Don't forget to return the result.
     */
    public interface IRemainderOfTwoNumbers
    {
        int Get(int x, int y);
    }
    public class RemainderOfTwoNumbers : IRemainderOfTwoNumbers
    {
        public int Get(int x, int y)
        {
            var remainder = x% y;
            return remainder;
        }
    }
}
