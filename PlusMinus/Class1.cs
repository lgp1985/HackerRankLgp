class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double total = arr.Count();
        Console.WriteLine(string.Join(Environment.NewLine, new[] {
            arr.Count(s => s > 0) / total,
            arr.Count(s => s < 0) / total,
            arr.Count(s => s == 0) / total,
        }.Select(s => s.ToString("N6"))));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
