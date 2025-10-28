using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                if (input.Equals("finish", StringComparison.OrdinalIgnoreCase)) break;

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0].ToLower();

                switch (command)
                {
                    case "ins":
                        if (parts.Length == 3)
                        {
                            int index = int.Parse(parts[1]);
                            int element = int.Parse(parts[2]);
                            if (index >= 0 && index <= numbers.Count)
                            {
                                numbers.Insert(index, element);
                            }
                        }
                        break;

                    case "del":
                        if (parts.Length == 2)
                        {
                            int element = int.Parse(parts[1]);
                            numbers.Remove(element);
                        }
                        break;

                    case "contains":
                        if (parts.Length == 2)
                        {
                            int element = int.Parse(parts[1]);
                            Console.WriteLine(numbers.Contains(element) ? "Yes" : "No");
                        }
                        break;

                    case "remove":
                        if (parts.Length == 2)
                        {
                            int index = int.Parse(parts[1]);
                            if (index >= 0 && index < numbers.Count)
                            {
                                numbers.RemoveAt(index);
                            }
                        }
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
            }
        }
    }
}
