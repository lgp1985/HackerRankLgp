class Result
{

    /*
     * Complete the 'legoBlocks' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     */

    public static int legoBlocks(int n, int m)
    {
        // Write your code here
        var divisor = 7 + (int)Math.Pow(10, 9);
        var p = new long[m]; // combination count of one row of m length
        for (var i = 0; i < m; i++)
        {
            if (i == 0) p[i] = 1;
            else if (i == 1) p[i] = 2;
            else if (i == 2) p[i] = 4;
            else if (i == 3) p[i] = 8;
            else p[i] = (p[i - 1] + p[i - 2] + p[i - 3] + p[i - 4]) % divisor;
        }

        // all possible (good or bad) combinations count of a n * x (1<=x<=m) wall
        var a = new long[m];
        for (var i = 0; i < m; i++)
        {
            long base1 = p[i], times = n, res = base1;
            while (times > 1)
            {
                res = (res * base1) % divisor;
                times--;
            }
            a[i] = res;
        }

        // good combinations count of a n * x (1<=x<=m) wall
        var g = new long[m];
        for (var i = 0; i < m; i++)
        {
            if (i == 0) g[i] = 1;
            else
            {
                var pGood = a[i];
                for (var j = 0; j < i; j++)
                {
                    pGood -= g[j] * a[i - j - 1] % divisor;
                }
                while (pGood < 0)
                {
                    pGood += divisor;
                }
                g[i] = pGood;
            }
        }
        return (int)(g[m - 1] % divisor);

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
            var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            var n = Convert.ToInt32(firstMultipleInput[0]);

            var m = Convert.ToInt32(firstMultipleInput[1]);

            var result = Result.legoBlocks(n, m);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
