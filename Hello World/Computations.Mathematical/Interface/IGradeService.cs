using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Mathematical.Interface
{
    internal interface IGradeService
    {
        float AverageOf2Subject(int math, int science);
        float AverageOf3Subject(int math, int science, int english);
        float AverageOf4Subject(int math, int science, int english, int computer);

    }
}
