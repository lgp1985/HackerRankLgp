class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        var sorted = arr.Select(s => Convert.ToInt64(s));
        Console.WriteLine(string.Join(' ', new[] {
            sorted.Take(4).Sum(),
            sorted.TakeLast(4).Sum()
        }));
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        var arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
