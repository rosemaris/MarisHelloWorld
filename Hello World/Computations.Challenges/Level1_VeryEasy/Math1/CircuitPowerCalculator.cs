using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.Level1_VeryEasy
{
    /*
     * === Circuit Power Calculator ===
                Create a function that takes voltage and current and returns the calculated power.

                Examples
                CircuitPower(230, 10) ➞ 2300
                CircuitPower(110, 3) ➞ 330
                CircuitPower(480, 20) ➞ 9600

                Notes
                power = voltage * current
     */
    public interface ICircuitPowerCalculator
    {
        int Calulate(int voltage, int current);
    }
    public class CircuitPowerCalculator : ICircuitPowerCalculator
    {
        public int Calulate(int voltage, int current)
        {
            var power = voltage * current;
            return power;
        }
    }
}
