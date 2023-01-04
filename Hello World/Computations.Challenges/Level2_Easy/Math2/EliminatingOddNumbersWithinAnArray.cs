using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Eliminate Odd Numbers within an Array ===
     
            Create a function that takes an array of numbers and returns only the even values.

            Examples
            NoOdds([1, 2, 3, 4, 5, 6, 7, 8]) ➞ [2, 4, 6, 8]
            
            NoOdds([43, 65, 23, 89, 53, 9, 6]) ➞ [6]
            
            NoOdds([718, 991, 449, 644, 380, 440]) ➞ [718, 644, 380, 440]
            Notes
            Return all even numbers in the order they were given.
            All test cases contain valid numbers ranging from 1 to 3000.
     */

    public interface IEliminatingOddNumbersWithinAnArray
    {
        int[] Get(int[] arr);
    }
    public class EliminatingOddNumbersWithinAnArray : IEliminatingOddNumbersWithinAnArray
    {
        public int[] Get(int[] arr)
        {
            var evenNums = new int[arr.Length];
            for (int Index=0; Index <arr.Length;Index++)
            {
                if (arr[Index] % 2 == 0)
                {
                    evenNums[Index] = arr[Index];
                }
                  
            }
            int delete = 0;
            evenNums=Array.FindAll(evenNums,numbers => numbers != delete).ToArray();
            return evenNums;
        }
    }

    /*https://codescracker.com/c/program/c-program-print-even-array-elements.htm */
    /*https://www.techiedelight.com/remove-specified-element-from-array-csharp/ */
}
