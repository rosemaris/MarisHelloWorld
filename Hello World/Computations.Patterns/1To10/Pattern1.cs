using System;

namespace Computations.Patterns
{
    public class Pattern1 : IPattern
    {
        public string Create(int size)
        {
            string output = "";

            for (int col = 1; col <= size; col++)
            {
                for (int row = 1; row <= size; row++)
                {
                    output += "*"+" ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
