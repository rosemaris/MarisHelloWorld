using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * === Recursion: Sum  ===
     
                Write a function that recursively finds the sum of the first n natural numbers.

                Examples
                Sum(5) ➞ 15
                // 1 + 2 + 3 + 4 + 5 = 15
                
                Sum(1) ➞ 1
                
                Sum(12) ➞ 78
                Notes
                Assume the input number is always positive.
     */
    public interface IRecursionSum
    {
        int Get(int n);
    }
    public class RecursionSum : IRecursionSum
    {
        public int Get(int n)
        {
            int recursion = 0;
            for (int index = 1; index <= n; index++)
            {
                recursion +=  index;
            }
            return recursion;
        }
    }
}
