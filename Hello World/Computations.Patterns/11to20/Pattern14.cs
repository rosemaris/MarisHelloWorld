using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern14 : IPattern
    {
        public string Create(int size)
        {
           string output = "";

            for (int col =size; col >= 1; col--)
            {
                int k = 0;
                for (int row = 1; row <= size; row++)
                {
                    output += (col + k) + " ";
                    k += 5;
                }
                output += "\n";
            }
            return output;
        }
    }
    
}
