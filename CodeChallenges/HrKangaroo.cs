using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CodeChallenges
{
	public static class HrKangaroo
	{
		private static readonly string NO = "NO";
		private static readonly string YES = "YES";

		public static string kangaroo(int x1, int v1, int x2, int v2)
		{
			return v2 >= v1 ? NO : ((x1 - x2) % (v2 - v1)).Equals(0) ? YES : NO;
		}

	}
}
