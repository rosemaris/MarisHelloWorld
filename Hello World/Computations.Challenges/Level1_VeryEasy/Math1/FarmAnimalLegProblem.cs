﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === The Farm Problem  ===
     
                 In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. The farmer breeds three species:
                chickens = 2 legs
                cows = 4 legs
                pigs = 4 legs
                The farmer has counted his animals and he gives you a subtotal for each species. You have to implement a function that 
                returns the total number of legs of all the animals.
                
                Examples
                animals(2, 3, 5) ➞ 36
                animals(1, 2, 3) ➞ 22
                animals(5, 2, 8) ➞ 50

                Notes
                Don't forget to return the result.
                The order of animals passed is animals(chickens, cows, pigs).
                Remember that the farmer wants to know the total number of legs and not the total number of animals.
     */
    public interface IFarmAnimalLegProblem
    {
        int get(int chickens, int cows, int pigs);
    }
    public class FarmAnimalLegProblem : IFarmAnimalLegProblem
    {
        public int get(int chickens, int cows, int pigs)
        {
            var totalLegs = (chickens*2) + (cows*4) + (pigs*4);
            return totalLegs;
        }
    }
}
