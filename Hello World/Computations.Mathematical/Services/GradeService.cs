using Computations.Mathematical.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical
{
    public class GradeService : IGradeService
    {
        public float AverageOf2Subject(int math, int science)
        {
            var average = (math + science) / 2;
            return average;
        }

        public float AverageOf3Subject(int math, int science, int english)
        {
           var average = (math + science + english) / 3;
            return average;
        }

        public float AverageOf4Subject(int math, int science, int english, int computer)
        {
            var average = (math + science + english + computer) / 4;
            return average;
        }
    }
}

