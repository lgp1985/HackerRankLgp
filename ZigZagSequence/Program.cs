using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var t = int.Parse(Console.ReadLine().Trim());
        for (var i = 0; i < t; i++)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            findZigZagSequence(a);
        }
    }

    private static void findZigZagSequence(int[] a)
    {
        Array.Sort(a);
        var p1 = a.Take(a.Length / 2).ToArray();
        Array.Sort(a, (b, c) => c.CompareTo(b));
        var p2 = a.Take((a.Length + 1) / 2).ToArray();
        Console.Write(string.Join(" ", p1.Concat(p2)));
        Console.WriteLine();
    }
}