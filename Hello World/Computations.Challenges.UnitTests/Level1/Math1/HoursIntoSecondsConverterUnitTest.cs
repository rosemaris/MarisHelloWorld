using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
	[TestFixture]
	internal class HoursIntoSecondsConverterUnitTest
    {

		[Test]
		[TestCase(2, ExpectedResult = 7200)]
		[TestCase(10, ExpectedResult = 36000)]
		[TestCase(24,ExpectedResult = 86400)]
		[TestCase(36, ExpectedResult = 129600)]

		public static int HowManySeconds(int hours)
		{
			var hoursIntoSecondsConverter = new HoursIntoSecondsConverter();
			return hoursIntoSecondsConverter.Convert(hours);
		}
	}
}
