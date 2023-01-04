using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class ReturnFactorialUnitTest
    {
        [Test]
        [TestCase(2, ExpectedResult = 2)]
        [TestCase(6, ExpectedResult = 720)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(12, ExpectedResult = 479001600)]
        [TestCase(5, ExpectedResult = 120)]
        public static int Get_ShouldReturnToFactorialNumber_WhenPassingANumber(int num)
        {
            var returnFactorial = new ReturnFactorial();
            return returnFactorial.Get(num);
        }
    }
}
