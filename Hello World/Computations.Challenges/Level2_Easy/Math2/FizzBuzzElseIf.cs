using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  FizzBuzz Interview Question ===
     
                    Create a function that takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz".

                    If the number is a multiple of 3 the output should be "Fizz".
                    If the number given is a multiple of 5, the output should be "Buzz".
                    If the number given is a multiple of both 3 and 5, the output should be "FizzBuzz".
                    If the number is not a multiple of either 3 or 5, the number should be output on its own as shown in the examples below.
                    The output should always be a string even if it is not a multiple of 3 or/and 5.
                   
                    Examples
                    FizzBuzz(3) ➞ "Fizz"
                    FizzBuzz(5) ➞ "Buzz"
                    FizzBuzz(15) ➞ "FizzBuzz"
                    FizzBuzz(4) ➞ "4"
                    Notes
                    Try to be precise with how you spell things and where you put the capital letters.
     */
    public interface IFizzBuzzElseIf
    {
        string Get(int n);
    }
    public class FizzBuzzElseIf : IFizzBuzzElseIf
    {
        public string Get(int n)
        {
            int num1 = n%3;
            int num2 = n%5;
            if ((num1 == 0) && (num2 == 0))
                return "FizzBuzz";
            if (num1 == 0)
                return "Fizz";
            if (num2 == 0)
                return "Buzz";
             else
                return n.ToString();
        }
    }
}
