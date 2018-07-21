namespace CodeKatas.CSharp.Fibonacci
{
	/// <summary>
	/// Different Fibonacci implementations.
	/// </summary>
	public static class FibonacciEx
	{
		/// <summary>
		/// Fibonacci with recursion.
		/// </summary>
		/// <param name="n">Number in sequence.</param>
		/// <returns></returns>
		public static int FibonacciRec(int n) => n > 1 ? FibonacciRec(n - 1) + FibonacciRec(n - 2) : n;

		/// <summary>
		/// Fibonacci with for.
		/// </summary>
		/// <param name="n">Number in sequence.</param>
		/// <returns></returns>
		public static int FibonacciFor(int n)
		{
			if (n == 0)
				return 0;

			int first = 0;
			int second = 1;

			for (int i = 1; i < n; i++)
			{
				int temp = second;
				second = first + second;
				first = temp;
			}

			return second;
		}
	}
}
