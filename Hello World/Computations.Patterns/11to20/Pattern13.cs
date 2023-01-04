using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern13 : IPattern
    {
        public string Create(int size)
        {
            string output = "";

            for (int col = 1; col <= size; col++)
            {
              int x= col;
                int y= (size-col)+1;
                for (int row = 1; row <= size; row++)
                {
                    if (row%2==1)
                    {
                        output += x + " ";
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
