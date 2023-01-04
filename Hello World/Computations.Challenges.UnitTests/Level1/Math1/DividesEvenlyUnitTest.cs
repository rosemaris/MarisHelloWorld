using Computations.Challenges.Level1_VeryEasy.Math;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    internal class DividesEvenlyUnitTest
    {
		[Test]

		[TestCase(98, 7,    ExpectedResult = true)]
		[TestCase(87, 49, ExpectedResult = false)]
		[TestCase(34, 14, ExpectedResult = false)]
		[TestCase(78, 6,   ExpectedResult= true)]
		[TestCase(30, 4,  ExpectedResult= false)]
		[TestCase(87, 73, ExpectedResult= false)]
		[TestCase(74, 7,   ExpectedResult= false)]
		[TestCase(87, 29, ExpectedResult = true)]
		[TestCase(48, 24,ExpectedResult = true)]
		[TestCase(99, 20,ExpectedResult = false)]
		[TestCase(98, 49,ExpectedResult = true)]
		[TestCase(100, 6, ExpectedResult = false)]
		[TestCase(64, 4,   ExpectedResult = true)]
		[TestCase(70, 35, ExpectedResult = true)]
		[TestCase(38, 38, ExpectedResult = true)]
		[TestCase(29, 3,   ExpectedResult = false)]
		[TestCase(20, 8,   ExpectedResult = false)]
		[TestCase(66, 50,ExpectedResult = false)]
		[TestCase(95, 1,   ExpectedResult = true)]
		[TestCase(58, 2, ExpectedResult = true)]

		public static bool FixedTest(int a, int b)
		{
			var dividesEvenly = new DividesEvenly();
			return dividesEvenly.IsDividedEvenly(a, b);
		}
	}
}
