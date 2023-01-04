using Computations.Challenges.Level1_VeryEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level1
{
    [TestFixture]
    internal class AddingPolygonAnglesUnitTest
    {
		[Test]
		[TestCase(21, ExpectedResult = 3420)]
		[TestCase(22, ExpectedResult = 3600)]
		[TestCase(3, ExpectedResult= 180)]
		[TestCase(4, ExpectedResult =360)]
		[TestCase(5, ExpectedResult =540)]
		[TestCase(6, ExpectedResult =720)]
		[TestCase(7, ExpectedResult =900)]
		[TestCase(8, ExpectedResult =1080)]
		[TestCase(9, ExpectedResult =1260)]
		[TestCase(10, ExpectedResult = 1440)]
		[TestCase(11, ExpectedResult= 1620)]
		[TestCase(12, ExpectedResult = 1800)]
		[TestCase(13, ExpectedResult= 1980)]
		[TestCase(14, ExpectedResult= 2160)]
		[TestCase(15, ExpectedResult= 2340)]
		[TestCase(16, ExpectedResult= 2520)]
		[TestCase(17, ExpectedResult= 2700)]
		[TestCase(18, ExpectedResult= 2880)]
		[TestCase(19, ExpectedResult= 3060)]
		[TestCase(20, ExpectedResult = 3240)]

		public static int SumPolygon(int num)
		{
			var addingPolygonAngles = new AddingPolygonAngles();
			return addingPolygonAngles.Get(num);
		}
	}
}
