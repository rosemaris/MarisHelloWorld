using NUnit.Framework;

namespace Computations.Challenges.UnitTests
{
	[TestFixture]
	public class MinuteToSecondsConverterUnitTest
	{
		[Test]
		[TestCase(6, ExpectedResult = 360)]
		[TestCase(4, ExpectedResult = 240)]
		[TestCase(8, ExpectedResult = 480)]
		[TestCase(60, ExpectedResult = 3600)]
		public static int Convert(int a)
		{
			var minuteToSecondsConverter = new MinuteToSecondsConverter();

			return minuteToSecondsConverter.Convert(a);
		}
	}
}