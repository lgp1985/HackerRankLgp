class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int principalDiagonal = 0, secondaryDiagonal = 0;
        for (var i = 0; i < arr.Count; i++)
        {
            for (var j = 0; j < arr[i].Count; j++)
            {
                if (i == j)
                { principalDiagonal += arr[i][j]; }
                if ((i + j) == (arr.Count - 1))
                { secondaryDiagonal += arr[i][j]; }
            }
        }
        return Math.Abs(principalDiagonal - secondaryDiagonal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var arr = new List<List<int>>();

        for (var i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        var result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
