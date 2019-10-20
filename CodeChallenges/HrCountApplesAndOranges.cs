using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
	public static class HrCountApplesAndOranges
	{
		// ReSharper disable once InconsistentNaming
		public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
		{

			int[] result = new[] {0, 0};

			foreach (var apple in apples)
			{
				var applePosition = a + apple;
				if (s <= applePosition && t >= applePosition)
				{
					result[0] += 1;
				}
			}

			foreach (var orange in oranges)
			{
				var orangePosition = b + orange;
				if (s <= orangePosition && t >= orangePosition)
				{
					result[1] += 1;
				}
			}

			foreach (int i in result)
			{
				Console.WriteLine(i);
			}

		}
	}
}
