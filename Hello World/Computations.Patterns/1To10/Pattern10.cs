using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern10 : IPattern
    {
        public string Create(int size)
        {
            string output = "";

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    output += j +" "+ i+ " ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
