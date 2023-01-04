using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Is the Average of All Elements a Whole Number?  ===
     
                     Create a function that takes an array as an argument and returns true or false 
                depending on whether the average of all elements in the array is a whole number or not.

                Examples
                IsAvgWhole([1, 3]) ➞ true
                IsAvgWhole([1, 2, 3, 4]) ➞ false
                IsAvgWhole([1, 5, 6]) ➞ true
                IsAvgWhole([1, 1, 1]) ➞ true
                IsAvgWhole([9, 2, 2, 5]) ➞ false
     */

    public interface IAverageOfElementAWholeNumber
    {
        bool IsAverageWholeNumber(int[] arr);
    }
    public class AverageOfElementAWholeNumber : IAverageOfElementAWholeNumber
    {
        public bool IsAverageWholeNumber(int[] arr)
        {
            int sumDisplay = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                sumDisplay += (arr[index]);
            }

            var averageResult = sumDisplay % arr.Length;
            if (averageResult == 0)
                return true;
            else
                return false;
        }
    }
}
