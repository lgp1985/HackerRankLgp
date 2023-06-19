class Solution
{
    enum Operation
    {
        append = 1,
        delete = 2,
        print = 3,
        undo = 4
    }
    static (Operation operation, string? value) ConsoleReadAsCommand()
    {
        var parts = Console.ReadLine().Split(' ');
        return ((Operation)Convert.ToInt32(parts[0]), parts.Length == 2 ? parts[1] : null);
    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var numberOfQueries = Convert.ToInt32(Console.ReadLine());
        var queue = new Stack<string>();
        for (var i = 0; i < numberOfQueries; i++)
        {
            var command = ConsoleReadAsCommand();
            switch (command.operation)
            {
                case Operation.append:
                    var l = (queue.TryPeek(out var result) ? result : null) + command.value;
                    queue.Push(l);
                    break;
                case Operation.delete:
                    var d = queue.Peek().Remove(queue.Peek().Length - Convert.ToInt32(command.value));
                    queue.Push(d);
                    break;
                case Operation.print:
                    var c = queue.Peek().ElementAt(Convert.ToInt32(command.value) - 1);
                    Console.WriteLine(c);
                    break;
                case Operation.undo:
                    _ = queue.Pop();
                    break;
            }
        }
    }
}