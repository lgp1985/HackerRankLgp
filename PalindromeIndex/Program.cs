class Result
{

    /*
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int palindromeIndex(string s)
    {
        var start = 0;
        var end = s.Length - 1;
        while (start < end && s.ElementAt(start) == s.ElementAt(end))
        {
            start++;
            end--;
        }
        if (start >= end) return -1; // already a palindrome
        if (isPalindrome(s, start + 1, end)) return start;
        if (isPalindrome(s, start, end - 1)) return end;
        return -1;
    }
    public static bool isPalindrome(string s, int start, int end)
    {
        while (start < end && s.ElementAt(start) == s.ElementAt(end))
        {
            start++;
            end--;
        }
        return start >= end;
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
            var s = Console.ReadLine();

            var result = Result.palindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
