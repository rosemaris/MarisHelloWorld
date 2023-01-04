using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Convert Age to Days  ===
     
                 Create a function that takes the age in years and returns the age in days.

                    Examples
                    CalcAge(65) ➞ 23725
                    CalcAge(0) ➞ 0
                    CalcAge(20) ➞ 7300

                    Notes
                    Use 365 days as the length of a year for this challenge.
                    Ignore leap years and days between last birthday and now.
                    Expect only positive integer inputs.
     */
    public interface IAgeToDaysConverter
    {
        int Convert(int age);
    }
    public class AgeToDaysConverter: IAgeToDaysConverter
    {
        public int Convert(int age)
        {
            var calcAge = age * 365;
            return calcAge;
        }
    }
}
