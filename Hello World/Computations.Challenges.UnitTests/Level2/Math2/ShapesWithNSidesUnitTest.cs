using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class ShapesWithNSidesUnitTest
    {

		[Test]
		[TestCase(1, ExpectedResult = "circle")]
		[TestCase(2, ExpectedResult = "semi-circle")]
		[TestCase(3, ExpectedResult= "triangle")]
		[TestCase(4, ExpectedResult = "square")]
		[TestCase(5, ExpectedResult= "pentagon")]
		[TestCase(6, ExpectedResult= "hexagon")]
		[TestCase(7, ExpectedResult= "heptagon")]
		[TestCase(8, ExpectedResult= "octagon")]
		[TestCase(9, ExpectedResult= "nonagon")]
		[TestCase(10,ExpectedResult = "decagon")]
		public static string Get_ShouldReturnWithShapeName_WhenPAssingANumber(int n)
		{
			var shapesWithNSides = new ShapesWithNSides();
			return shapesWithNSides.Get(n);
		}
		
			
	}
}
