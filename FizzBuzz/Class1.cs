class Result
{

    /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        var response = string.Empty;
        if (n % 3 == 0) { response += "Fizz"; }
        if (n % 5 == 0) { response += "Buzz"; }
        if (response.Length == 0) { response = n.ToString(); }
        Console.WriteLine(response);
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
