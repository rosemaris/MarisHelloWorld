using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class CalculatingMeanUnitTest
    {
        [Test]
        [TestCase(new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 }, ExpectedResult = 2.55)]
        [TestCase(new int[] { 324, 543, 654, 9876 }, ExpectedResult = 2849.25)]
        [TestCase(new int[] { 0, 0, 0, 0 }, ExpectedResult = 0.00)]
        [TestCase(new int[] { 30, 40, 20, 100, 30 }, ExpectedResult = 44.00)]
        [TestCase(new int[] { 1, 1, 1, 0 }, ExpectedResult = 0.75)]
        [TestCase(new int[] { 1, 1, 0, 1, 2, 1, 1, 1, 0, 0 }, ExpectedResult = 0.80)]
        [TestCase(new int[] { 10000 }, ExpectedResult = 10000.00)]
        public static double Get_ShouldReturnToMean_WhenPassingAnArray(int[] arr)
        {
            var calculatingMean = new CalculatingMean();
            return calculatingMean.GetMean(arr);
        }
    }
}
