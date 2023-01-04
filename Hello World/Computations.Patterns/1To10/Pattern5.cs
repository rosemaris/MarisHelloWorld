using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern5 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            for (int col = size; col >= 1; col--)
            {
                for (int row = size; row >= 1; row--)
                {
                    output += row+" ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
