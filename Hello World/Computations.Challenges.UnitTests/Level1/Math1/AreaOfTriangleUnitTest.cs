using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class AreaOfTriangleUnitTest
    {
		[Test]
		[TestCase(3, 2, ExpectedResult = 3)]
		[TestCase(5, 4, ExpectedResult = 10)]
		[TestCase(10, 10, ExpectedResult = 50)]
		[TestCase(0, 60, ExpectedResult = 0)]
		[TestCase(12, 11, ExpectedResult = 66)]
		public static int TriArea(int b, int h)
		{
			var areaOfTriangle = new AreaOfTriangle();
			return areaOfTriangle.Get(b, h);
		}
	}
}
