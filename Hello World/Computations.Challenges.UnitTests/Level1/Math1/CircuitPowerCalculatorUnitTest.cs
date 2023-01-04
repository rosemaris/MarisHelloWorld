using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class CircuitPowerCalculatorUnitTest
    {
		[Test]
		[TestCase(110, 3, ExpectedResult = 330)]
		[TestCase(230, 10, ExpectedResult = 2300)]
		[TestCase(480, 20, ExpectedResult = 9600)]

		public static int CircuitPower(int voltage, int current)
		{
			var circuitPowerCalculator = new CircuitPowerCalculator();
			return circuitPowerCalculator.Calulate(voltage, current);
		}
	}
}
