using Computations.Mathematical.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical
{
    public class GradeAverageResultServices : IGradeAverageResultServices
    {
        public string GetResult(float average)
        {
            if (average >= 100) 
                return "Your Grade is INVALID"; 
            else if (average >= 98)
                return "You're WITH HIGHEST HONORS"; 
            else if (average >= 95) 
                return "You're WITH HIGH HONORS"; 
            else if (average >= 90)
                return "You're WITH HONORS"; 
            else if (average >= 75)
                return "You've PASSED"; 
            else
                return "You've FAILED"; 
        }
    }
}
