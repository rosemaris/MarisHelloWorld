using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern12 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            
            for (int col = 1; col <= size; col++)
            {
                int k = 0;
                for (int row = 1; row <= size; row++)
                {
                    output += (col + k) + " ";
                    k+=5;
                }
                output += "\n";
            }
            return output;
        }
    }
}
