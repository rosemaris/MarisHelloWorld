﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Patterns
{
    public class Pattern3 : IPattern
    {
        public string Create(int size)
        {
            string output = "";

            for (int col= 1; col <= size; col++)
            {
                for (int row = 1; row <= size; row++)
                {
                    output += row+" ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
