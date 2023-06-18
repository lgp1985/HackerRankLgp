class Result
{

    /*
     * Complete the 'truckTour' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY petrolpumps as parameter.
     */

    public static int truckTour(List<List<int>> petrolpumps)
    {
        var n = petrolpumps.Count;
        for (var i = 0; i < n; i++)
        {
            var petrol = 0;
            var index = i;
            if (petrolpumps[i][0] < petrolpumps[i][1])
                continue;
            while (true)
            {
                petrol += petrolpumps[index][0];
                petrol -= petrolpumps[index][1];
                if (petrol < 0)
                    break;
                index = (index + 1) % n;
                if (index == i)
                    break;
            }
            if (index == i)
                return i;
        }
        return -1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var n = Convert.ToInt32(Console.ReadLine().Trim());

        var petrolpumps = new List<List<int>>();

        for (var i = 0; i < n; i++)
        {
            petrolpumps.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(petrolpumpsTemp => Convert.ToInt32(petrolpumpsTemp)).ToList());
        }

        var result = Result.truckTour(petrolpumps);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
