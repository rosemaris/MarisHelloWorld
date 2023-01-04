using Computations.Challenges.Level1_VeryEasy.Math;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    internal class FramePerSecondUnitTest
    {
        [Test]
        [TestCase(1, 1, ExpectedResult = 60)]
        [TestCase(10, 1, ExpectedResult = 600)]
        [TestCase(10, 25, ExpectedResult = 15000)]
        [TestCase(500, 60, ExpectedResult = 1800000)]
        [TestCase(0, 60, ExpectedResult = 0)]
        [TestCase(99, 1, ExpectedResult = 5940)]
        [TestCase(419, 70, ExpectedResult = 1759800)]
        [TestCase(52, 33, ExpectedResult = 102960)]
        public static int Frames(int a, int b)
        {
            var framePerSecond = new FramePerSecond();
            return framePerSecond.Frames(a, b);
        }
    }
}
