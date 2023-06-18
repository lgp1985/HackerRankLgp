using System.Text;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        var chars = new { lower = new char[] { 'a', 'z' }, upper = new char[] { 'A', 'Z' } };
        k = k % (chars.lower.Last() - chars.lower.First() + 1);
        var stringBuilder = new StringBuilder();
        foreach (var c in s.AsSpan())
        {
            if (c >= chars.lower.First() && c <= chars.lower.Last())
            {
                var z = (chars.lower.Last() - chars.lower.First() + 1) * ((c + k < chars.lower.First()) ? 1 : (c + k > chars.lower.Last()) ? -1 : 0);
                _ = stringBuilder.Append((char)(c + k + z));
            }
            else if (c >= chars.upper.First() && c <= chars.upper.Last())
            {
                var z = (chars.upper.Last() - chars.upper.First() + 1) * ((c + k < chars.upper.First()) ? 1 : (c + k > chars.upper.Last()) ? -1 : 0);
                _ = stringBuilder.Append((char)(c + k + z));
            }
            else
                _ = stringBuilder.Append(c);
        }
        return stringBuilder.ToString();
    }
    /*
     * worst test case
78
1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M
27
     */
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        _ = Convert.ToInt32(Console.ReadLine().Trim());

        var s = Console.ReadLine();

        var k = Convert.ToInt32(Console.ReadLine().Trim());

        var result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
