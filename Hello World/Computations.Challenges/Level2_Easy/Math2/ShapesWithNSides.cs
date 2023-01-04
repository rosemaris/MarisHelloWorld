using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level2_Easy.Math2
{
    /*
     * === Shapes With N Sides  ===
     
                  Create a function that takes a whole number as input and returns the shape with that number's amount of sides. 
                  Here are the expected outputs to get from these inputs.

                Inputs	Outputs
                1	"circle"
                2	"semi-circle"
                3	"triangle"
                4	"square"
                5	"pentagon"
                6	"hexagon"
                7	"heptagon"
                8	"octagon"
                9	"nonagon"
                10	"decagon"

                Examples
                NSidedShape(3) ➞ "triangle"
                NSidedShape(1) ➞ "circle"
                NSidedShape(9) ➞ "nonagon"

                Notes
                There won't be any tests with a number below 1 or greater than 10.
                Return the output in lowercase.
                The challenge is intended to be completed without conditionals (it would take too long)!
     */
    public interface IShapesWithNSides
    {
        string Get(int n);
    }
    public class ShapesWithNSides : IShapesWithNSides
    {
        public string Get(int n)
        {
            string nSideName;
            switch(n)
            {
                case 1: nSideName = "circle";
                    break;
                case 2: nSideName = "semi-circle";
                    break ;
                case 3: nSideName = "triangle";
                    break;
                case 4:nSideName = "square";
                    break;
                case 5: nSideName = "pentagon";
                    break;
                case 6: nSideName = "hexagon";
                    break;
                case 7: nSideName = "heptagon";
                    break;
                case 8: nSideName = "octagon";
                    break;
                case 9: nSideName = "nonagon";
                    break;
                case 10:nSideName = "decagon";
                    break;
               default: nSideName = "";
                    break;
            }
            return nSideName;
        }
    }
}
