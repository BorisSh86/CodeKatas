using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKatas.CSharp.ArrayRotation
{
	[TestFixture]
	public class ArrayRotationTests
	{
		[TestCase(new int[0], -2, ExpectedResult = new int[0])]
		[TestCase(new int[0], -1, ExpectedResult = new int[0])]
		[TestCase(new int[0], 0, ExpectedResult = new int[0])]
		[TestCase(new int[0], 1, ExpectedResult = new int[0])]
		[TestCase(new int[0], 2, ExpectedResult = new int[0])]
		[TestCase(new int[] { 1 }, -2, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, -1, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, 0, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, 1, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, 2, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1, 2, 3 }, -4, ExpectedResult = new int[] { 2, 3, 1 })]
		[TestCase(new int[] { 1, 2, 3 }, -3, ExpectedResult = new int[] { 1, 2, 3 })]
		[TestCase(new int[] { 1, 2, 3 }, -2, ExpectedResult = new int[] { 3, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3 }, -1, ExpectedResult = new int[] { 2, 3, 1 })]
		[TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = new int[] { 1, 2, 3 })]
		[TestCase(new int[] { 1, 2, 3 }, 1, ExpectedResult = new int[] { 3, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 2, 3, 1 })]
		[TestCase(new int[] { 1, 2, 3 }, 3, ExpectedResult = new int[] { 1, 2, 3 })]
		[TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 3, 1, 2 })]
		public int[] RotateArrayWithFor(int[] arr, int shift)
		{
			return ArrayRotationEx.RotateArrayWithFor(arr, shift);
		}

		[TestCase(new int[0], -2, ExpectedResult = new int[0])]
		[TestCase(new int[0], -1, ExpectedResult = new int[0])]
		[TestCase(new int[0], 0, ExpectedResult = new int[0])]
		[TestCase(new int[0], 1, ExpectedResult = new int[0])]
		[TestCase(new int[0], 2, ExpectedResult = new int[0])]
		[TestCase(new int[] { 1 }, -2, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, -1, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, 0, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, 1, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1 }, 2, ExpectedResult = new int[] { 1 })]
		[TestCase(new int[] { 1, 2, 3 }, -4, ExpectedResult = new int[] { 2, 3, 1 })]
		[TestCase(new int[] { 1, 2, 3 }, -3, ExpectedResult = new int[] { 1, 2, 3 })]
		[TestCase(new int[] { 1, 2, 3 }, -2, ExpectedResult = new int[] { 3, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3 }, -1, ExpectedResult = new int[] { 2, 3, 1 })]
		[TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = new int[] { 1, 2, 3 })]
		[TestCase(new int[] { 1, 2, 3 }, 1, ExpectedResult = new int[] { 3, 1, 2 })]
		[TestCase(new int[] { 1, 2, 3 }, 2, ExpectedResult = new int[] { 2, 3, 1 })]
		[TestCase(new int[] { 1, 2, 3 }, 3, ExpectedResult = new int[] { 1, 2, 3 })]
		[TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 3, 1, 2 })]
		public int[] RotateArrayWithQueue(int[] arr, int shift)
		{
			return ArrayRotationEx.RotateArrayWithQueue(arr, shift);
		}
	}
}
