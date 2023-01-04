using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Basketball Points  ===
     
                 You are counting points for a basketball game, given the amount of 3-pointers scored and 2-pointers scored,
                    find the final points for the team and return that value ([2 -pointers scored, 3-pointers scored]).

                Examples
                points(1, 1) ➞ 5
                points(7, 5) ➞ 29
                points(38, 8) ➞ 100
     */
    public interface ICountingPoints
    {
        int Get(int twoPointers, int threePointers);
    }
    public class CountingPoints : ICountingPoints
    {
        public int Get(int twoPointers, int threePointers)
        {
            var totalPoints = (twoPointers * 2) + (threePointers * 3);
            return totalPoints;
        }
    }
}
