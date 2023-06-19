class Result
{

    /*
     * Complete the 'pairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int pairs(int k, List<int> arr)
    {
        var tuples = new List<(int, int)>();
        foreach (var item in arr)
        {
            if (arr.Contains(item + k))
                tuples.Add((item, item + k));
        }
        return tuples.Count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        var n = Convert.ToInt32(firstMultipleInput[0]);

        var k = Convert.ToInt32(firstMultipleInput[1]);

        var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        var result = Result.pairs(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
