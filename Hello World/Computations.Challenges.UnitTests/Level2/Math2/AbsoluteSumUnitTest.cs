using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class AbsoluteSumUnitTest
    {
        [Test]
        [TestCase(new int[] { 2, -1, -3, 4, 8 }, ExpectedResult = 18)]
        [TestCase(new int[] { -1 }, ExpectedResult = 1)]
        [TestCase(new int[] { -1, -3, -5, -4, -10, 0 }, ExpectedResult = 23)]
        [TestCase(new int[] { 8, 9, 10, 32, 101, -10 }, ExpectedResult = 170)]
        [TestCase(new int[] { 500 }, ExpectedResult = 500)]
        public static int GetAbsSum_ShouldReturnToAbsoluteSum_WhenPassingArray(int[] arr)
        {
            var absoluteSum = new AbsoluteSum();
            return absoluteSum.GetAbsSum(arr);
        }
    }
}
