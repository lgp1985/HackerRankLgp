class Result
{

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static void minimumBribes(List<int> q)
    {
        var maxBribe = q.Select((sticker, position) => new { sticker, position = position + 1 })
            .Select(s => Math.Max(0, s.sticker - s.position))
            .Max();
        var sumBribes = q.Select((sticker, position) => new { sticker, position })
            .Aggregate(seed: 0, func: (bribe, element) => bribe + q
                .Take(new Range(Math.Max(0, element.sticker - 3), element.position))
                .Count(previousElement => previousElement > element.sticker));
        Console.WriteLine(maxBribe > 2 ? "Too chaotic" : sumBribes);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine().Trim());

        for (var tItr = 0; tItr < t; tItr++)
        {
            var n = Convert.ToInt32(Console.ReadLine().Trim());

            var q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

            Result.minimumBribes(q);
        }
    }
}
