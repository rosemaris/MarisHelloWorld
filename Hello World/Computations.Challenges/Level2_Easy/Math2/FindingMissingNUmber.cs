using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Find the Missing Number ===
     
                Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.

                Examples
                MissingNum([1, 2, 3, 4, 6, 7, 8, 9, 10]) ➞ 5
                MissingNum([7, 2, 3, 6, 5, 9, 1, 4, 8]) ➞ 10
                MissingNum([10, 5, 1, 2, 4, 6, 8, 3, 9]) ➞ 7

                Notes
                The array of numbers will be unsorted (not in order).
                Only one number will be missing.
     */
    public interface IFindingMissingNUmber
    {
        int MissingNum(int[] arr);
    }
    public class FindingMissingNUmber : IFindingMissingNUmber
    {
        public int MissingNum(int[] arr)
        {
            int missingNUmber;
            int TotalSum;
            TotalSum = (arr.Length + 1) *(arr.Length+2)/2;
            foreach(int item in arr)
            {
                TotalSum -= item;
            }
            missingNUmber = TotalSum;
            return missingNUmber;
        }
    }
    /*https://interviewsansar.com/find-missing-number-between-1-to-n-in-array-in-c/ */
}
