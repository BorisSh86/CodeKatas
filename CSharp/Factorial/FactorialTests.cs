using NUnit.Framework;

namespace CodeKatas.CSharp.Factorial
{
	public class FactorialTests
	{
		[TestCase(0, ExpectedResult = 1)]
		[TestCase(1, ExpectedResult = 1)]
		[TestCase(2, ExpectedResult = 2)]
		[TestCase(3, ExpectedResult = 6)]
		[TestCase(4, ExpectedResult = 24)]
		[TestCase(5, ExpectedResult = 120)]
		[TestCase(6, ExpectedResult = 720)]
		[TestCase(7, ExpectedResult = 5040)]
		[TestCase(8, ExpectedResult = 40320)]
		[TestCase(9, ExpectedResult = 362880)]
		[TestCase(10, ExpectedResult = 3628800)]
		public int FactorialRec(int n)
		{
			return FactorialEx.FactorialRec(n);
		}

		[TestCase(0, ExpectedResult = 1)]
		[TestCase(1, ExpectedResult = 1)]
		[TestCase(2, ExpectedResult = 2)]
		[TestCase(3, ExpectedResult = 6)]
		[TestCase(4, ExpectedResult = 24)]
		[TestCase(5, ExpectedResult = 120)]
		[TestCase(6, ExpectedResult = 720)]
		[TestCase(7, ExpectedResult = 5040)]
		[TestCase(8, ExpectedResult = 40320)]
		[TestCase(9, ExpectedResult = 362880)]
		[TestCase(10, ExpectedResult = 3628800)]
		public int FactorialFor(int n)
		{
			return FactorialEx.FactorialFor(n);
		}
		
		[TestCase(0, ExpectedResult = 1)]
		[TestCase(1, ExpectedResult = 1)]
		[TestCase(2, ExpectedResult = 2)]
		[TestCase(3, ExpectedResult = 6)]
		[TestCase(4, ExpectedResult = 24)]
		[TestCase(5, ExpectedResult = 120)]
		[TestCase(6, ExpectedResult = 720)]
		[TestCase(7, ExpectedResult = 5040)]
		[TestCase(8, ExpectedResult = 40320)]
		[TestCase(9, ExpectedResult = 362880)]
		[TestCase(10, ExpectedResult = 3628800)]
		public int FactorialLinq(int n)
		{
			return FactorialEx.FactorialLinq(n);
		}
	}
}
