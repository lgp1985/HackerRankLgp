class Result
{

    /*
     * Complete the 'towerBreakers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     */
    public static int towerBreakers(int n, int m)
    {
        if (m == 1) { return 2; }
        return n % 2 == 0 ? 2 : 1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var textWriter = new StreamWriter(new MemoryStream());

        var t = Convert.ToInt32(Console.ReadLine().Trim());

        for (var tItr = 0; tItr < t; tItr++)
        {
            var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            var n = Convert.ToInt32(firstMultipleInput[0]);

            var m = Convert.ToInt32(firstMultipleInput[1]);

            var result = Result.towerBreakers(n, m);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
