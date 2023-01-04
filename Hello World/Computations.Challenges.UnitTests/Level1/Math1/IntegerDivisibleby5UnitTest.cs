using Computations.Challenges.Level1_VeryEasy;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class IntegerDivisibleby5UnitTest
    {
        [Test]
		[TestCase(7, ExpectedResult = false)]
		[TestCase(5, ExpectedResult = true)]
		[TestCase(15, ExpectedResult = true)]
		[TestCase(33, ExpectedResult = false)]
		[TestCase(-18, ExpectedResult = false)]
		[TestCase(999, ExpectedResult = false)]
		[TestCase(2, ExpectedResult = false)]
		public static bool divisibleByFive(int x)
		{
			var integerDivisibleby5 = new IntegerDivisibleby5();
			return integerDivisibleby5.IsDivisibleByFive(x);
		}
	}
}
