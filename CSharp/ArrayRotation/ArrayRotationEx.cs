using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.CSharp.ArrayRotation
{
	/// <summary>
	/// Array rotation implementation.
	/// </summary>
	public static class ArrayRotationEx
	{
		/// <summary>
		/// Rotate array with for loop.
		/// </summary>
		/// <param name="source">Source array.</param>
		/// <param name="shift">Rotation count.</param>
		/// <returns>Rotated array.</returns>
		public static int[] RotateArrayWithFor(int[] source, int shift)
		{
			if (source == null || source.Length == 0)
				return source;

			shift %= source.Length;
			if (shift == 0)
				return source;

			int[] rotated = new int[source.Length];

			for (int i = 0; i < source.Length; i++)
			{
				int rotatedIndex;

				if ((i + shift) < source.Length && (i + shift) >= 0)
				{
					rotatedIndex = i + shift;
				}
				else
				{
					rotatedIndex = Math.Abs(source.Length - Math.Abs(i + shift));
				}

				rotated[rotatedIndex] = source[i];
			}

			return rotated;
		}

		/// <summary>
		/// Rotate array with queue.
		/// </summary>
		/// <param name="source">Source array.</param>
		/// <param name="shift">Rotation count.</param>
		/// <returns>Rotated array.</returns>
		public static int[] RotateArrayWithQueue(int[] source, int shift)
		{
			if (source == null || source.Length == 0)
				return source;

			shift %= source.Length;
			if (shift == 0)
				return source;	
			
			Queue<int> queue = new Queue<int>(shift > 0 ? source.Reverse() : source);

			for (int i = 0; i < Math.Abs(shift); i++)
			{
				queue.Enqueue(queue.Dequeue());
			}

			return shift > 0 ? queue.Reverse().ToArray() : queue.ToArray();
		}
	}
}
