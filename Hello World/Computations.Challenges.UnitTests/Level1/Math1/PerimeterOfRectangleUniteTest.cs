using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
	[TextFixture]
    internal class PerimeterOfRectangleUniteTest
    {
		[Test]
		[TestCase(6, 7, ExpectedResult = 26)]
		[TestCase(20, 10, ExpectedResult = 60)]
		[TestCase(2, 9, ExpectedResult = 22)]

		public static int FindPerimeter(int length, int width)
		{
			var perimeterOfRectangle = new PerimeterOfRectangle();
			return perimeterOfRectangle.Get(length, width);
		}
	}
}
