using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Area of a Triangle  ===
     
                Write a function that takes the base and height of a triangle and return its area.

                Examples
                triArea(3, 2) ➞ 3
                triArea(7, 4) ➞ 14
                triArea(10, 10) ➞ 50

                Notes
                The area of a triangle is: (base * height) / 2
                Don't forget to return the result.
     */
    public interface IAreaOfTriangle
    {
        int Get(int b, int h);
    }
    public class AreaOfTriangle: IAreaOfTriangle
    {
        public int Get(int b, int h)
        {
            var triArea = (b*h)/2;
            return triArea;
        }

    }
}
