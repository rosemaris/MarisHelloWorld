using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern15 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            for (int col= 1; col <= size; col++)
            {
                int y = (size - col) + 1;
                int x = col;
                for (int row= 1; row <= size; row++)
                {
                   if (row%2==0)
                    {
                        output += x+ " ";
                    }
                   else
                    {
                        output += y+ " ";
                    }
                    x += size;
                    y += size;
                }
                output += "\n";
            }
            return output;
        }
    }
}
