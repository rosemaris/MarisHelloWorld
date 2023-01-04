using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
	[TestFixture]
	internal class LessThan100ComparisonUnitTest
    {
		[Test]
		[TestCase(5, 57, ExpectedResult = true)]
		[TestCase(77, 30, ExpectedResult= false)]
		[TestCase(0, 59, ExpectedResult= true)]
		[TestCase(78, 35, ExpectedResult = false)]
		[TestCase(63, 11, ExpectedResult = true)]
		[TestCase(37, 99,ExpectedResult = false)]
		[TestCase(52, 11,ExpectedResult = true)]
		[TestCase(82, 95,ExpectedResult = false)]
		[TestCase(17, 44, ExpectedResult = true)]
		[TestCase(74, 53, ExpectedResult = false)]
		[TestCase(3, 77, ExpectedResult =true)]
		[TestCase(25, 80,ExpectedResult = false)]
		[TestCase(59, 28,ExpectedResult = true)]
		[TestCase(69, 87,ExpectedResult = false)]
		[TestCase(10, 45,ExpectedResult = true)]
		[TestCase(43, 58,ExpectedResult = false)]
		[TestCase(50, 44,ExpectedResult = true)]
		[TestCase(74, 89,ExpectedResult = false)]
		[TestCase(3, 27, ExpectedResult =true)]
		[TestCase(21, 79, ExpectedResult = false)]

		public static bool LessThan100(int a, int b)
		{
			var lessThan100Comparison = new LessThan100Comparison();
			return lessThan100Comparison.IsLessThan100(a, b);
		}
	}
}
