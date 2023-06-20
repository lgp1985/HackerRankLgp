class Result
{
    /*
2
4 2
1 2
1 3
1
*/
    /*
     * Complete the 'bfs' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     *  3. 2D_INTEGER_ARRAY edges
     *  4. INTEGER s
     */

    public static List<int> bfs(int n, int m, List<List<int>> edges, int s)
    {
        var graph = new Dictionary<int, LinkedList<int>>(n);
        for (var i = 1; i <= n; i++)
            graph.Add(i, new LinkedList<int>());
        foreach (var edge in edges)
        {
            _ = graph[edge[0]].AddLast(edge[1]);
            _ = graph[edge[1]].AddLast(edge[0]);
        }

        var visited = Enumerable.Range(1, n).ToDictionary(s => s, s => false);
        var distance = new Dictionary<int, int>();
        visited[s] = true;
        distance[s] = 0;

        var q = new Queue<int>();
        q.Enqueue(s);
        while (q.Count != 0)
        {
            var parent = q.Dequeue();
            foreach (var w in graph[parent])
            {
                if (!visited[w])
                {
                    q.Enqueue(w);
                    distance[w] = distance[parent] + 6;
                    visited[w] = true;
                }
            }
        }

        var result = Enumerable.Range(1, n).Where(w => w != s).Select(w => distance.TryGetValue(w, out var p) && p > 0 ? p : -1);
        return result.ToList();
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
            var firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            var n = Convert.ToInt32(firstMultipleInput[0]);

            var m = Convert.ToInt32(firstMultipleInput[1]);

            var edges = new List<List<int>>();

            for (var i = 0; i < m; i++)
            {
                edges.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(edgesTemp => Convert.ToInt32(edgesTemp)).ToList());
            }

            var s = Convert.ToInt32(Console.ReadLine().Trim());

            var result = Result.bfs(n, m, edges, s);

            textWriter.WriteLine(String.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
