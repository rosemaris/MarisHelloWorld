using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Maximum Edge of a Triangle  ===
     
                Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.

                Examples
                NextEdge(8, 10) ➞ 17
                NextEdge(5, 7) ➞ 11 
                NextEdge(9, 2) ➞ 10

                Notes
                (side1 + side2) - 1 = maximum range of third edge.
                The side lengths of the triangle are positive integers.
                Don't forget to return the result.
     */
    public interface IMaximumEdgeOfTriangle
    {
        int Get(int side1, int side2);
    }
    public class MaximumEdgeOfTriangle : IMaximumEdgeOfTriangle
    {
        public int Get(int side1, int side2)
        {
            var nextedge = (side1 + side2) - 1; 
            return nextedge;
        }
    }
}
