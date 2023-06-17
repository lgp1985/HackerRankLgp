class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        for (var i = 1; i <= n; i++)
        {
            var response = string.Empty;
            if (i % 3 == 0) { response += "Fizz"; }
            if (i % 5 == 0) { response += "Buzz"; }
            if (response.Length == 0) { response = i.ToString(); }
            Console.WriteLine(response);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
