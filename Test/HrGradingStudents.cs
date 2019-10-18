using System;
using System.Collections.Generic;

namespace CodeChallenges
{
	class HrGradingStudents
	{
		public static List<int> gradingStudents(List<int> grades)
		{
			int[] multiples = BuildMultOfFive();

			for (var j = 0; j < grades.Count; j++)
			{
				if (IsGradeToLowToRound(grades[j]))
				{
					continue;
				}

				foreach (var m in multiples)
				{
					if (IsWithinRoundingRange(m, grades[j]))
					{
						grades[j] = m;
					}
				}
			}
			grades.ForEach(Console.WriteLine);
			return grades;
		}

		private static int[] BuildMultOfFive()
		{
			int[] multOfFive = new int[20];
			for (int i = 0; i < multOfFive.Length; i++)
			{
				multOfFive[i] = (i + 1) * 5;
			}

			return multOfFive;
		}

		private static bool IsGradeToLowToRound(int num)
		{
			return (num < 38);
		}

		private static bool IsWithinRoundingRange(int multiple, int num)
		{
			var numberToTest = multiple - num;
			return (numberToTest > 0 && numberToTest < 3);
		}

		private static bool isDivisibleByFive(int num)
		{
			return (num % 5 == 0);
		}

		private static bool isLsThOrEquToOneHundred(int num)
		{
			return (num <= 100);
		}
	}
}