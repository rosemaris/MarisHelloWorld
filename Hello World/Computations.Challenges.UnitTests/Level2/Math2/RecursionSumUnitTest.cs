using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class RecursionSumUnitTest
    {
        [Test]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 3)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(5, ExpectedResult = 15)]

        public static int Get_ShouldReturnToRecursionSum_WhenPassingANumber(int n)
        {
            var recursionSum = new RecursionSum();
            return recursionSum.Get(n);
        }
    }
}
