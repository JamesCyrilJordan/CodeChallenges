using System;

namespace CodeChallenges
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// HrGradingStudents.gradingStudents(new List<int>() {73,67,38,33});
			// HrGridChallenge.CallGridChallenge();
			// HrLuckBalance.CallLuckBalance();
			HrCountApplesAndOranges.countApplesAndOranges(7, 11, 5, 15, new[] {-2, 2, 1}, new[] {5, -6});
			Console.ReadLine();
		}
	}
}


//   TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
// var fileContent = File.Open("./gridChallenge.csv", FileMode.Open);
// var array = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
// int t = Convert.ToInt32(fileContent.);
// for (int tItr = 0; tItr < t; tItr++)
// {

//     int n = Convert.ToInt32(Console.ReadLine());

//     string[] grid = new string[n];

//     for (int i = 0; i < n; i++)
//     {
//         string gridItem = Console.ReadLine();
//         grid[i] = gridItem;
//     }

//     string result = HrGridChallenge.gridChallenge(grid);

//     Console.WriteLine(result);
//     // textWriter.WriteLine(result);
// }

// textWriter.Flush();
// textWriter.Close();


//plusMinus(new int[7] {1, -2, -7, 9, 1, -8, -5});
//marcsCakewalk(new int[4] {7,4,9,6});
//Console.WriteLine(marcsCakewalk(new int[4] {7,4,9,6}).ToString());

//  Console.WriteLine(HrGridChallenge.gridChallenge(new string[] { "mpxz", "abcd", "wlmf" }));


// // Complete the marcsCakewalk function below.
// static long marcsCakewalk(int[] calorie)
// {
//     //var minVal = 0;
//     //var numCakes = calorie.Length;
//     //var tempCalories = new int[numCakes];
//     //calorie.CopyTo(tempCalories,0);

//     //for (var i = 0; i < numCakes; i++)
//     //{
//     //	var temp = 0;
//     //	for (var j = 0; j < numCakes; j++)
//     //	{
//     //		// get total
//     //		temp += 2 ^ j + tempCalories[j];
//     //	}

//     //	minVal = (minVal != 0 && minVal < temp) ? minVal : temp;

//     //	tempCalories = shiftValue(tempCalories);
//     //}
//     Array.Sort(calorie);
//     Array.Reverse(calorie);


//     return calorie.Select((t, i) => Convert.ToInt64(Math.Pow(2, i) * t)).Sum();
// }

// private static int[] shiftValue(int[] intArray)
// {
//     int[] newAr = new int[intArray.Length];
//     int valToShift = intArray[intArray.Length - 1];

//     for (int j = 0; j < intArray.Length - 1; j++)
//     {
//         newAr.SetValue(intArray[j], j + 1);
//     }

//     newAr.SetValue(valToShift, 0);
//     return newAr;
// }

// private static void plusMinus(int[] arr)
// {
//     double pos = 0, neg = 0, zero = 0;
//     if (arr.Length.Equals(0)) return;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         pos += arr[i] > 0 ? 1 : 0;
//         neg += arr[i] < 0 ? 1 : 0;
//         zero += arr[i] == 0 ? 1 : 0;
//     }

//     string date = "12:10 am";
//     DateTime test = DateTime.Parse(date);
//     Queue<int> test1 = new Queue<int>();

//     test.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
//     //List<int> newList = arr.ToList();

//     //newList.ForEach(x => x.Equals(arr.Max()));
//     Console.WriteLine((!pos.Equals(0) ? (pos / arr.Length) : 0).ToString("#.000000"));
//     Console.WriteLine((!neg.Equals(0) ? (neg / arr.Length) : 0).ToString("#.000000"));
//     Console.WriteLine((!zero.Equals(0) ? (zero / arr.Length) : 0).ToString("#.000000"));
// }