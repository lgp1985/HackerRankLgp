class Result
{

    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    public static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix.Count / 2, sz1 = matrix.Count - 1;
        var sum = 0;
        for (var y = 0; y < n; ++y) for (var x = 0; x < n; ++x)
            {
                var m1 = Math.Max(matrix[y][x], matrix[sz1 - y][x]);
                var m2 = Math.Max(matrix[y][sz1 - x], matrix[sz1 - y][sz1 - x]);
                sum += Math.Max(m1, m2);
            }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var q = Convert.ToInt32(Console.ReadLine().Trim());

        for (var qItr = 0; qItr < q; qItr++)
        {
            var n = Convert.ToInt32(Console.ReadLine().Trim());

            var matrix = new List<List<int>>();

            for (var i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            var result = Result.flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
