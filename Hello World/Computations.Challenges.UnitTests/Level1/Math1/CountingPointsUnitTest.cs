using Computations.Challenges.Level1_VeryEasy;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class CountingPointsUnitTest
    {
		[Test]
		[TestCase(1, 1, ExpectedResult = 5)]
		[TestCase(1, 2, ExpectedResult= 8)]
		[TestCase(2, 1, ExpectedResult= 7)]
		[TestCase(2, 2, ExpectedResult = 10)]
		[TestCase(69, 420, ExpectedResult = 1398)]

		public static int Points(int twoPointers, int threePointers)
		{
			var countingPoints = new CountingPoints();
			return countingPoints.Get(twoPointers, threePointers);
		}
	}
}
