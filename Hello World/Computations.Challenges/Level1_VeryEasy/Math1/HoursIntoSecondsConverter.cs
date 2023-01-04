using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * ===  Convert Hours into Seconds ===
     
                Write a function that converts hours into seconds.

                Examples
                howManySeconds(2) ➞ 7200
                howManySeconds(10) ➞ 36000
                howManySeconds(24) ➞ 86400
                Notes
                60 seconds in a minute, 60 minutes in an hour.
     */
    public interface IHoursIntoSecondsConverter
    {
        int Convert(int hours);
    }
    public class HoursIntoSecondsConverter : IHoursIntoSecondsConverter
    {
        public int Convert(int hours)
        {
            var seconds = hours * 3600;
            return seconds;
        }
    }
}
