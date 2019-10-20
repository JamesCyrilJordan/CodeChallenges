using System;
using System.Linq;

namespace CodeChallenges
{
	public class HrLuckBalance
	{
		public static void CallLuckBalance()
		{
			luckBalance(3, new int[][]
			{
				new int[] {5,1}, 
				new int[] {2,1},
				new int[] {1,1},
				new int[] {8,1},
				new int[] {10,0},
				new int[] {5,0} 
			});
		}
		static int luckBalance(int k, int[][] contests) {
			int[][] importantContests = contests.Where(x => x[1].Equals(1)).ToArray();
			int[][] importantContestsWithoutK = importantContests
				.OrderByDescending(x => x[0])
				.Take(k)
				.ToArray();
			int[][] kSmallestImportantContests = importantContests
				.OrderBy(x => x[0])
				.Take(importantContests.Length - k)
				.ToArray();
			int[][] unimportantContests = contests.Where(x => x[1].Equals(0)).ToArray();
			int luckAggregate = importantContestsWithoutK.Sum(t => t[0]);
			luckAggregate += unimportantContests.Sum(t => t[0]);
			return kSmallestImportantContests.Aggregate(luckAggregate, (current, t) => current - t[0]);
		}

		private static bool IsImportant(int num)
		{
			return (num.Equals(1));
		}

	}
}
