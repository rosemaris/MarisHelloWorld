using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern8 : IPattern
    {
        public string Create(int size)
        {
            string output = "";
            int controlNumber = 2;
            for(int i = 1; i <= size; i++)
            {
                for(int j = 1; j <= size; j++)
                {
                    output += controlNumber + " ";
                    controlNumber+=2;
                }
                output += "\n";
            }
            return output;
        }
    }
}
