using Computations.Challenges.Level2_Easy.Math2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Computations.Challenges.UnitTests.Level2.Math2
{
    internal class FizzBuzzElseIfUnitTest
    {
		[Test]
		[TestCase(3, ExpectedResult = "Fizz")]
		[TestCase(5, ExpectedResult = "Buzz")]
		[TestCase(15, ExpectedResult = "FizzBuzz")]
		[TestCase(98, ExpectedResult = "98")]
		[TestCase(10, ExpectedResult = "Buzz")]
		[TestCase(4, ExpectedResult = "4")]
		public static string Get_ShouldReturnToCorrespondingFizz_WhenPassingANumber(int n)
		{
			var fizzBuzzElseIf = new FizzBuzzElseIf();	
			return fizzBuzzElseIf.Get(n);
		}
	}
}
