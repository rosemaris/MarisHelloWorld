using System;

namespace Computations.Challenges
{
    /*
 * ===Convert Minutes into Seconds===

            Write a function that takes an integer minutes and converts it to seconds.

            Examples
            convert(5) ➞ 300
            convert(3) ➞ 180
            convert(2) ➞ 120

            Notes:
            Don't forget to return the result.
*/

    public interface IMinuteToSecondsConverter
    {
        int Convert(int minute);
    }

    public class MinuteToSecondsConverter : IMinuteToSecondsConverter
    {
        public int Convert(int minute)
        {
            var seconds = minute * 60;

            return seconds;
        }
    }
}
