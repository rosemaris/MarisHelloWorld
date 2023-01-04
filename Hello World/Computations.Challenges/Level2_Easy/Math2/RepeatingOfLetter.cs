using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * ===  Burrrrrrrp ===
     
    Create a function that returns the string "Burp" with the amount of "r's" determined by the input parameters of the function.

Examples
LongBurp(3) ➞ "Burrrp"

LongBurp(5) ➞ "Burrrrrp"

LongBurp(9) ➞ "Burrrrrrrrrp"
Notes
Expect num to always be >= 1.
Remember to use a capital "B".
Don't forget to return the result.
     */
    public interface IRepeatingOfLetter
    {
        string Get(int b);
    }
    public class RepeatingOfLetter : IRepeatingOfLetter
    {
        public string Get(int b)
        {
            string letter = new String('r', b);
            return "Bu"+letter+'p';

        }
    }
}