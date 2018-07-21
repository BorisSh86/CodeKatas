using System.Linq;

namespace CodeKatas.CSharp.Factorial
{
	/// <summary>
	/// Different factorial implementations.
	/// </summary>
	public static class FactorialEx
	{
		/// <summary>
		/// Factorial with recursion.
		/// </summary>
		/// <param name="n">Number.</param>
		/// <returns></returns>
		public static int FactorialRec(int n) => n > 0 ? n * FactorialRec(n - 1) : 1;

		/// <summary>
		/// Factorial with for.
		/// </summary>
		/// <param name="n">Number.</param>
		/// <returns></returns>
		public static int FactorialFor(int n)
		{
			if (n == 0)
				return 1;

			int factorial = 1;

			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
			}

			return factorial;
		}

		/// <summary>
		/// Factorial with linq.
		/// </summary>
		/// <param name="n">Number.</param>
		/// <returns></returns>
		public static int FactorialLinq(int n) => n > 0 ? Enumerable.Range(1, n).Aggregate((total, i) => total * i) : 1;
	}
}
