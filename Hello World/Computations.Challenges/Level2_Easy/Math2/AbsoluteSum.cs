using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Absolute Sum ===
     
                Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.

                Examples
                getAbsSum([2, -1, 4, 8, 10]) ➞ 25
                getAbsSum([-3, -4, -10, -2, -3]) ➞ 22
                getAbsSum([2, 4, 6, 8, 10]) ➞ 30
                getAbsSum([-1]) ➞ 1

                Notes
                The term "absolute value" means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).
                All the elements in the given array are integers.
     */
    public interface IAbsoluteSum
    {
        int GetAbsSum(int[] arr);
    }

    public class AbsoluteSum : IAbsoluteSum
    {
        public int GetAbsSum(int[] arr)
        {
            int abssum = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                var absolute = Math.Abs(arr[index]);
                abssum += absolute;
            }
            return abssum;
            
        }

        /* https://www.c-sharpcorner.com/blogs/how-to-find-sum-of-an-array-of-numbers-in-c-sharp */
    }
}
