using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class AgeToDaysConverterUnitTest
    {
		[Test]
		[TestCase(10, ExpectedResult = 3650)]
		[TestCase(0, ExpectedResult = 0)]
		[TestCase(73, ExpectedResult = 26645)]
		public static int CalcAge(int age)
		{
			var ageToDaysConverter = new AgeToDaysConverter();
			return ageToDaysConverter.Convert(age);
		}
	}
}
