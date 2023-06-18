class Result
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        var list = new List<IOrderedEnumerable<char>>();
        foreach (var item in grid)
        {
            list.Add(item.ToCharArray().OrderBy(c => c));
        }
        for (var i = 0; i < grid.First().Length; i++)
        {
            var col = new string(list.Select(s => s.ElementAt(i)).ToArray());
            var orderedCol = new string(col.OrderBy(c => c).ToArray());
            if (col != orderedCol)
            {
                return "NO";
            }
        }
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var t = Convert.ToInt32(Console.ReadLine().Trim());

        for (var tItr = 0; tItr < t; tItr++)
        {
            var n = Convert.ToInt32(Console.ReadLine().Trim());

            var grid = new List<string>();

            for (var i = 0; i < n; i++)
            {
                var gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            var result = Result.gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
