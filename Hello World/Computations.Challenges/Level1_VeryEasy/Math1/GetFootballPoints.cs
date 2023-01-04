using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Football Points  ===
     
                Create a function that takes the number of wins, draws and losses and calculates the number of points a football team has obtained so far.
                wins get 3 points
                draws get 1 point
                losses get 0 points

                Examples
                FootballPoints(3, 4, 2) ➞ 13
                FootballPoints(5, 0, 2) ➞ 15
                FootballPoints(0, 0, 1) ➞ 0

                Notes
                Inputs will be numbers greater than or equal to 0.
     */

    public interface IGetFootballPoints
    {
        int Get(int wins, int draws, int losses);
    }
    public class GetFootballPoints : IGetFootballPoints
    {
        public int Get(int wins, int draws, int losses)
        {
            var totalPoints = (wins*3) + (draws*1) + (losses*0);
            return totalPoints;
        }
    }
}
