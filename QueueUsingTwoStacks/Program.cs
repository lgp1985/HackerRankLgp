using System;
using System.Collections.Generic;

class Solution
{
    static (Operation operation, int? value) ConsoleReadAsCommand()
    {
        var parts = Console.ReadLine().Split(' ');
        return ((Operation)Convert.ToInt32(parts[0]), parts.Length == 2 ? Convert.ToInt32(parts[1]) : null);
    }
    enum Operation
    {
        Enqueue = 1,
        Dequeue = 2,
        Print = 3,
    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var numberOfQueries = Convert.ToInt32(Console.ReadLine());
        var queue = new Queue<int?>();
        for (var i = 0; i < numberOfQueries; i++)
        {
            var command = ConsoleReadAsCommand();
            switch (command.operation)
            {
                case Operation.Enqueue:
                    queue.Enqueue(command.value);
                    break;
                case Operation.Dequeue:
                    _ = queue.Dequeue();
                    break;
                case Operation.Print:
                    Console.WriteLine(queue.Peek());
                    break;
            }
        }
    }
}