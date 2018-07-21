using NUnit.Framework;

namespace CodeKatas.CSharp.Fibonacci
{
	[TestFixture]
	public class FibonacciTests
	{
		[TestCase(0, ExpectedResult = 0)]
		[TestCase(1, ExpectedResult = 1)]
		[TestCase(2, ExpectedResult = 1)]
		[TestCase(3, ExpectedResult = 2)]
		[TestCase(4, ExpectedResult = 3)]
		[TestCase(5, ExpectedResult = 5)]
		[TestCase(6, ExpectedResult = 8)]
		[TestCase(7, ExpectedResult = 13)]
		[TestCase(8, ExpectedResult = 21)]
		[TestCase(9, ExpectedResult = 34)]
		[TestCase(10, ExpectedResult = 55)]
		public int FibonacciRec(int n)
		{
			return FibonacciEx.FibonacciRec(n);
		}

		[TestCase(0, ExpectedResult = 0)]
		[TestCase(1, ExpectedResult = 1)]
		[TestCase(2, ExpectedResult = 1)]
		[TestCase(3, ExpectedResult = 2)]
		[TestCase(4, ExpectedResult = 3)]
		[TestCase(5, ExpectedResult = 5)]
		[TestCase(6, ExpectedResult = 8)]
		[TestCase(7, ExpectedResult = 13)]
		[TestCase(8, ExpectedResult = 21)]
		[TestCase(9, ExpectedResult = 34)]
		[TestCase(10, ExpectedResult = 55)]
		public int FibonacciFor(int n)
		{
			return FibonacciEx.FibonacciFor(n);
		}		
	}
}
