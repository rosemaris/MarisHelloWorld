using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class NextNumberGreaterThanABUnitTest
    {
		[Test]
		[TestCase(17, 8, ExpectedResult = 24)]
		[TestCase(98, 3, ExpectedResult = 99)]
		[TestCase(14, 11, ExpectedResult = 22)]
		[TestCase(11, 8, ExpectedResult = 16)]
		[TestCase(450, 36, ExpectedResult = 468)]
		[TestCase(1019, 13, ExpectedResult = 1027)]

		public static int DivisibleByB(int a, int b)
		{
			var nextNumberGreaterThanAB = new NextNumberGreaterThanAB();
			return nextNumberGreaterThanAB.Get(a, b);
		}
	}
}
