class Result
{

    /*
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(List<int> arr)
    {
        var count = arr.Count;
        if (count % 2 == 0) { throw new Exception("out of scope"); }
        arr.Sort();
        return arr.ElementAt(arr.Count / 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        var result = Result.findMedian(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
