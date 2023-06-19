public class Result
{

    /*
     * Complete the 'isBalanced' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isBalanced(string s)
    {
        bool isMatch(char open, char close) => open switch { '{' => '}', '[' => ']', '(' => ')' } == close;

        var stack = new Stack<char>();
        foreach (var elm in s.AsSpan())
            if (new[] { '{', '[', '(' }.Any(s => elm == s))
                stack.Push(elm);
            else if (new[] { '}', ']', ')' }.Any(s => elm == s))
                if (!stack.TryPop(out var fromStack) || !isMatch(fromStack, elm))
                    return "NO";

        if (stack.Count == 0)
            return "YES";
        else
            return "NO";
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
            var s = Console.ReadLine();

            var result = Result.isBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
