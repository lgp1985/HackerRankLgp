class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        long result = n.Sum(c => c - '0');
        result *= k;
        return result > 9 ? superDigit(result.ToString(), 1) : (int)result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        var n = firstMultipleInput[0];

        var k = Convert.ToInt32(firstMultipleInput[1]);

        var result = Result.superDigit(n, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
