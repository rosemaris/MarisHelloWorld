using Computations.Challenges.Level1_VeryEasy;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class FootballPoints
    {
        [Test]
        [TestCase(1, 2, 3, ExpectedResult = 5)]
        [TestCase(5, 5, 5, ExpectedResult = 20)]
        [TestCase(1, 0, 0, ExpectedResult = 3)]
        [TestCase(0, 7, 0, ExpectedResult = 7)]
        [TestCase(0, 0, 15, ExpectedResult = 0)]
        public static int footballPoints(int a, int b, int c)
        {
            var getFootballPoints = new GetFootballPoints();
            return getFootballPoints.Get(a, b, c);
        }
    }
}
