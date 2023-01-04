using Computations.Challenges.Level1_VeryEasy;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class FarmAnimalLegProblemUnitTest
    {
		[Test]
		[TestCase(5, 2, 8, ExpectedResult = 50)]
		[TestCase(3, 4, 7, ExpectedResult= 50)]
		[TestCase(1, 2, 3, ExpectedResult = 22)]
		[TestCase(3, 5, 2, ExpectedResult = 34)]
		public static int Animals(int a, int b, int c)
		{
			var farmAnimalLegProblem = new FarmAnimalLegProblem();
			return farmAnimalLegProblem.get(a, b, c);
		}
	}
}
