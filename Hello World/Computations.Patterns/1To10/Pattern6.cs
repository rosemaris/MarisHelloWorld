using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern6 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            int k = 1;
            for (int col = 1; col <= size; col++)
            {
                for (int row=1; row <= size; row++)
                {
                    output += k + " ";
                    k++;
                }
                
                output += "\n";
            }
            return output;
        }
    }
}
