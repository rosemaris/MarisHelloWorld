using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Sum of Polygon Angles  ===
     
                Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).

                Examples
                SumPolygon(3) ➞ 180
                SumPolygon(4) ➞ 360
                SumPolygon(6) ➞ 720

                Notes
                n will always be greater than 2.
                The formula (n - 2) x 180 gives the sum of all the measures of the angles of an n-sided polygon.
     */
    public interface IAddingPolygonAngles
    {
        int Get(int num);
    }
    public class AddingPolygonAngles : IAddingPolygonAngles
    {
        public int Get(int num)
        {
            var sum = (num - 2) * 180;
            return sum;
        }
    }
}
