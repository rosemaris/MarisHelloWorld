using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class MultiplyByLengthUnitTest
    {
		[Test]
		public void Get_ShouldReturnToArrayMultiplyByLength_WhenArraysIsPass()
		{
			int[] i1 = { 2, 6, 4, 9 };
			int[] i2 = { 4, 1, 1 };
			int[] i3 = { 1, 0, 3, 3, 7, 2, 1 };
			int[] i4 = { 0 };

			int[] o1 = { 8, 24, 16, 36 };
			int[] o2 = { 12, 3, 3 };
			int[] o3 = { 7, 0, 21, 21, 49, 14, 7 };
			int[] o4 = { 0 };

			var multiplyByLength = new MultiplyByLength();
			Assert.AreEqual(o1, multiplyByLength.Get(i1));
			Assert.AreEqual(o2,multiplyByLength.Get(i2));
			Assert.AreEqual(o3, multiplyByLength.Get(i3));
			Assert.AreEqual(o4, multiplyByLength.Get(i4));
		}
	}
}
