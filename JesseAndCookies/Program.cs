class Result
{

    /*
     * Complete the 'cookies' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY A
     */

    public static int cookies(int k, List<int> A)
    {
        var cookies = new System.Collections.Generic.PriorityQueue<int, int>(A.Select(s => (s, s)));
        var initSize = cookies.Count;
        while (cookies.Peek() < k && cookies.Count >= 2)
        {
            var newCookie = cookies.Dequeue() + cookies.Dequeue() * 2;
            cookies.Enqueue(newCookie, newCookie);
        }
        return (cookies.Peek() >= k) ? initSize - cookies.Count : -1;
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

        var A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

        var result = Result.cookies(k, A);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
