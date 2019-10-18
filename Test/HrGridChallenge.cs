using System;
using System.IO;

namespace CodeChallenges
{
    public class HrGridChallenge
    {	
		public static void CallGridChallenge()
		{
			using (StreamReader sr = new StreamReader("./gridChallenge.csv"))
			{
				int t = Convert.ToInt32(sr.ReadLine());

				for (int tItr = 0; tItr < t; tItr++)
				{
					int n = Convert.ToInt32(sr.ReadLine());
					string[] grid = new string[n];
					
					for (int i = 0; i < n; i++)
					{
						string gridItem = sr.ReadLine();
						grid[i] = gridItem;
					}

					string result = HrGridChallenge.gridChallenge(grid);

					Console.WriteLine(result);

				}
				Console.ReadLine();
			}
		}

        private static string gridChallenge(string[] grid)
        {
            for (var i = 0; i < grid.Length; i++)
            {
                char[] tempRow = grid[i].ToCharArray();
                Array.Sort(tempRow);
                string newStr = new string(tempRow);
                grid[i] = newStr;
            }

            for (var i = 0; i < grid.Length; i++)
            {
                int compareResults = i == 0
                    ? grid[i][0].CompareTo(grid[i][0])
                    : grid[i - 1][0].CompareTo(grid[i][0]);

                if (compareResults > 0) return "NO";
            }
            return "YES";
        }
        // private string[] _grid;
        // public HrGridChallenge(string[] grid)
        // {
        //     _grid = grid;
        // }

        // public string gridChallenge()
        // {
        //     bool isAlpha = false;
        //     var temp = "";
        //     for (var i = 0; i < _grid.Length; i++)
        //     {
        //         char[] tempRow = _grid[i].ToCharArray();
        //         Array.Sort(tempRow);
        //         string newStr = new string(tempRow);
        //         _grid[i] = newStr;
        //         if (string.Compare(_grid[i], temp, StringComparison.Ordinal).Equals(-1))
        //         {
        //             isAlpha = true;
        //         }
        //     }
        //     return isAlpha ? "YES" : "NO";
        // }

        //public string gridChallenge( string[] grid) {
        //	bool isAlpha = false;
        //	var temp = "";

        //	for(var i = 0; i < grid.Length; i++){
        //		char[] tempRow = grid[i].ToArray();
        //		Array.Sort(tempRow);
        //		grid[i] = tempRow.ToString();
        //		if(grid[i].CompareTo(temp) == 1) {
        //			isAlpha = true;
        //		}
        //	}        
        //	return isAlpha ? "YES" : "NO";
        //}
    }
}
