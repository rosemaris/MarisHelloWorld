using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern4 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            for (int col =size; col >= 1; col--)
            {
                 for (int row = size; row >= 1; row--)
                {
                    output += col+" ";
                }
                output += "\n";
            }
            return output;

        }
    }
}
