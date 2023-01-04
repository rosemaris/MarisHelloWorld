using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern2 : IPattern
    {
        public string Create(int size)
        {
            string output = "";

            for (int col = 1; col <= size; col++)
            {
                for (int row = 1; row <= size; row++)
                {
                    output += col+" ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
