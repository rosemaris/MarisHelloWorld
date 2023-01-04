using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * === Calculate the Mean  ===
     
            Create a function that takes an array of numbers and returns the mean (average) of all those numbers.

            Examples
            Mean([1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3]) ➞ 2.55
            Mean([2, 3, 2, 3]) ➞ 2.50
            Mean([3, 3, 3, 3, 3]) ➞ 3.00

            Notes
            Round to two decimal places.
               You can expect a number ranging from 0 to 10,000.
     */
    public interface ICalculatingMean
    {
        double GetMean(int[] arr);
    }
    public class CalculatingMean : ICalculatingMean
    {
        public double GetMean(int[] arr)
        {
            int arrSum = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                arrSum += arr[index];
            }
            var arrLength = arr.Length;
            var meanString = String.Format("{0:0.00}", (double)arrSum / arrLength);
            var meanFInal = Convert.ToDouble(meanString);
            return meanFInal;
        }
    }
    /*https://dirask.com/posts/C-NET-calculate-average-of-array-1wME3p */
     /*https://www.csharp-examples.net/string-format-double/#:~:text=For%20two%20decimal%20places%20use%20pattern%20%E2%80%9E0.00%E2%80%9C. */
}
