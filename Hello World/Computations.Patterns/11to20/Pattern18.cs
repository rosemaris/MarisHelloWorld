using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern18 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            for (int col=1;col<= size; col++)
            {
                int k;
                for (int row = 1; row <= size; row++)
                {
                    if ((col+row) % 2 == 0)
                    {
                        k = 0;
                    }
                    else
                    {
                        k = 1;
                    }
                    
                    output += k + " ";
                }
                output += "\n";
            }
            return output;  
        }
    }
}
