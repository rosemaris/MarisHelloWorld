using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Find the Perimeter of a Rectangle  ===
     
                Create a function that takes length and width and finds the perimeter of a rectangle.

                Examples
                FindPerimeter(6, 7) ➞ 26
                FindPerimeter(20, 10) ➞ 60
                FindPerimeter(2, 9) ➞ 22

                Notes
                Don't forget to return the result.
     */

    public interface IPerimeterOfRectangle
    {
        int Get(int length, int width);
    }
    public class PerimeterOfRectangle : IPerimeterOfRectangle
    {
        public int Get(int length, int width)
        {
            var perimeter = (length+width)*2;
            return perimeter;
        }
    }
}
