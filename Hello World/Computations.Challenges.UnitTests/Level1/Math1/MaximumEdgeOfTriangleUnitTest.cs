using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
	internal class MaximumEdgeOfTriangleUnitTest
	{
		[Test]
		[TestCase(5, 4, ExpectedResult = 8)]
		[TestCase(8, 3, ExpectedResult = 10)]
		[TestCase(7, 9, ExpectedResult = 15)]
		[TestCase(10, 4, ExpectedResult = 13)]
		[TestCase(7, 2, ExpectedResult = 8)]

		public static int NextEdge(int side1, int side2)
		{
			var maximumEdgeOfTriangle = new MaximumEdgeOfTriangle();
			return maximumEdgeOfTriangle.Get(side1, side2);
		}

	}
}
