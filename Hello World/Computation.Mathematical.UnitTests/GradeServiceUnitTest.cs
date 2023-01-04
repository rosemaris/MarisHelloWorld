using Computations.Mathematical;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Computation.Mathematical.UnitTests
{
    public class GradeServiceUnitTest
    {
        [Fact]
        public void Averageof2numbers_AverageEqualsto85_WhenPAssing85()
        {
            var gradeService = new GradeService();
            float expected = 85;
            int math = 85;
            int science = 85;

            float grade2 = gradeService.AverageOf2Subject(math, science);
            Assert.Equal(expected, grade2);
        }

        [Fact]
        public void Averageof3numbers_AverageEqualsto70_WhenPAssing70()
        {
            var gradeService = new GradeService();
            float expected = 70;
            int math = 70;
            int science = 70;
            int english = 70;
            float average3 = gradeService.AverageOf3Subject(math, science, english);
            Assert.Equal(expected, average3);
        }

        [Fact]
        public void Averageof4numbers_AverageEqualsto80_WhenPAssing80()
        {
            var gradeService = new GradeService();
            float expected = 80;
            int math = 80;
            int science = 80;
            int english = 80;
            int computer = 80;
            float average4 = gradeService.AverageOf4Subject(math, science, english, computer);
            Assert.Equal(expected, average4);
        }
    }
   
}
