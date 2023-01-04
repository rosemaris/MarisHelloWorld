using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class PowerOfNumberUnitTest
    {
        [Test]
        [TestCase(5, 5, ExpectedResult = 3125)]
        [TestCase(3, 3, ExpectedResult = 27)]
        [TestCase(10, 10, ExpectedResult = 10000000000)]
        public static long Get_ShouldReturnPowerOfNumbers_WhenPassingNumberandExponent(long number, long exponent)
        {
          var powerOfNumber = new PowerOfNumber();
            return powerOfNumber.Get(number, exponent);
        }
    }
}
