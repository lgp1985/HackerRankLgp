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

    public static int V;
    public static List<int>[] adj;
    public static int[] distance;
    public static bool[] visited;
    public static void addEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }
    public static void initialize(int VV, int m, List<List<int>> edges)
    {
        V = VV;
        visited = new bool[V + 1];
        distance = new int[V + 1];
        adj = new List<int>[V + 1];
        for (var i = 0; i <= V; i++)
        {
            adj[i] = new List<int>();
        }
        for (var i = 0; i < m; i++)
        {
            addEdge(edges[i][0], edges[i][1]);
        }
    }

    public static List<int> bfs(int n, int m, List<List<int>> edges, int s)
    {
        initialize(n, m, edges);
        var q = new Queue<int>();
        var result = new int[n - 1];
        q.Enqueue(s);
        visited[s] = true;
        distance[s] = 0;
        while (q.Count() != 0)
        {
            var parent = q.Dequeue();
            foreach (var w in adj[parent])
            {
                if (!visited[w])
                {
                    q.Enqueue(w);
                    distance[w] = distance[parent] + 6;
                    visited[w] = true;
                }
            }

        }
        var original = 1;
        var trimmed = 0;
        while (original != n + 1)
        {
            if (original == s)
            {
                original += 1;
                continue;
            }
            result[trimmed] = distance[original];
            if (distance[original] == 0)
            {
                result[trimmed] = -1;
            }
            original += 1;
            trimmed += 1;
        }

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
