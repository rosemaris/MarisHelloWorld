using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Cumulative Array Sum ===
     
                    Create a function that takes an array of numbers and returns an array
                    where each number is the sum of itself + all previous numbers in the array.

                    Examples
                    CumulativeSum([1, 2, 3]) ➞ [1, 3, 6]
                    CumulativeSum([1, -2, 3]) ➞ [1, -1, 2]
                    CumulativeSum([3, 3, -2, 408, 3, 3]) ➞ [3, 6, 4, 412, 415, 418]

                    Notes
                    Return an empty array if the input is an empty array.
     */
    public interface ICUmulativeArraySum
    {
        double[] Get(double[] arr);
    }
    public class CUmulativeArraySum : ICUmulativeArraySum
    {
        public double[] Get(double[] arr)
        {
            for (int index = 1; index < arr.Length; index++)
            {
                arr[index] += arr[index-1];
            }
            return arr;
        }
    }
    /*https://www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-85.php */
}
