using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern11 : IPattern
    {
        public string Create(int size)
        {
            string output = "";

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    output += i + " " + j + " ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
