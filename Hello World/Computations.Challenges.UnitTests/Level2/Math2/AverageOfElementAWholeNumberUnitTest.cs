using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class AverageOfElementAWholeNumberUnitTest
    {
		[Test]
		[TestCase(new int[] { 3, 5, 9 }, ExpectedResult = false)]
		[TestCase(new int[] { 1, 1, 1, 1 }, ExpectedResult = true)]
		[TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = true)]
		[TestCase(new int[] { 5, 2, 4 }, ExpectedResult = false)]
		[TestCase(new int[] { 11, 22 }, ExpectedResult = false)]
		[TestCase(new int[] { 4, 1, 7, 9, 2, 5, 7, 2, 4 }, ExpectedResult = false)]
		public static bool Get_ShouldReturnToTRUEorFALSE_WhenPassingAnArray(int[] arr)
		{
			var averageOfElementAWholeNumber = new AverageOfElementAWholeNumber();
			return averageOfElementAWholeNumber.IsAverageWholeNumber(arr); 
		}
		
	}
}
