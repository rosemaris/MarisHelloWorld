using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class FindingMissingNUmberUnitTest
    {

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }, ExpectedResult = 5)]
        [TestCase(new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 }, ExpectedResult = 10)]
        [TestCase(new int[] { 7, 2, 3, 9, 4, 5, 6, 8, 10 }, ExpectedResult = 1)]
        [TestCase(new int[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 }, ExpectedResult = 7)]
        [TestCase(new int[] { 1, 7, 2, 4, 8, 10, 5, 6, 9 }, ExpectedResult = 3)]
        public static int Get_SHallReturnToTheMissingNUmber_WhenPAssingAnArray(int[] arr)
        {
            var findingMissingNUmber = new FindingMissingNUmber();
            return findingMissingNUmber.MissingNum(arr);
        }
    }
}
