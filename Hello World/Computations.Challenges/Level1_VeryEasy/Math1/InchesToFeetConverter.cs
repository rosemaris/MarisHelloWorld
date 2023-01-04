using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Inches to Feet  ===
    
                 Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.

                Examples
                inchesToFeet(324) ➞ 27
                inchesToFeet(12) ➞ 1
                inchesToFeet(36) ➞ 3

                Notes
                If inches are under 12, return 0.
                12 inches = 1 foot.

     */
    public interface IInchesToFeetConverter
    {
        int Convert(int inches);
    }
    public class InchesToFeetConverter : IInchesToFeetConverter
    {
        public int Convert(int inches)
        {
            var feet = inches / 12;
            if (feet >0)
                return feet;
            else
                return 0;
        }
    }
}
