using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern7 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            int k = 1;

            for (int col = 1; col <= size; col++)
            {
                for (int row=0; row < size; row++)
                {
                    output += k+" ";
                    k+=2;
                }
                output += "\n";
            }
            return output;
        }
    }
}
