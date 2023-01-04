using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern17 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
          
            for (int col = 0; col <size; col++)
            {
                int k = col+1;
                for (int row = 0; row <size; row++)
                {
                    output +=(col+row+k )+ " ";
                    k += 1;
                }
                output += "\n";
            }
            return output;
        }
    }
}
