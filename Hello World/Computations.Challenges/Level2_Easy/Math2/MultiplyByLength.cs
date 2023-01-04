using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Multiply by Length ===
     
                Create a function to multiply all of the values in an array by the amount of values in the given array.

                Examples
                MultiplyByLength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]
                MultiplyByLength([4, 1, 1]) ➞ ([12, 3, 3])
                MultiplyByLength([1, 0, 3, 3, 7, 2, 1]) ➞  [7, 0, 21, 21, 49, 14, 7]
                MultiplyByLength([0]) ➞ ([0])
                
                Notes
                All of the values given are numbers.
                All arrays will have at least one element.
                Don't forget to return the result.
     */
    public interface IMultiplyByLength
    {
        int[] Get(int[] arr);
    }
    public class MultiplyByLength : IMultiplyByLength
    { 

         public int[] Get(int[] arr)
        {
            var newNumxArray = new int[arr.Length];
            for(int index = 0; index < arr.Length; index++)
            {
                var NumberXArrLength = arr[index]*arr.Length;
                newNumxArray[index] = NumberXArrLength;
            }
            return newNumxArray;
        }
    }
}
