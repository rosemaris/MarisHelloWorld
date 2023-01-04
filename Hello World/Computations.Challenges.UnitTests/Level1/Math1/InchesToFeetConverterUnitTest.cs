using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    internal class InchesToFeetConverterUnitTest
    {
		[Test]
		[TestCase(12, ExpectedResult = 1)]
		[TestCase(360, ExpectedResult = 30)]
		[TestCase(3612, ExpectedResult = 301)]
		[TestCase(324, ExpectedResult = 27)]
		[TestCase(3012, ExpectedResult = 251)]
		[TestCase(11, ExpectedResult = 0)]

		public static int inchesToFeet(int inches)
		{
			var inchesToFeetConverter = new InchesToFeetConverter();
			return inchesToFeetConverter.Convert(inches);
		}
	}
}
