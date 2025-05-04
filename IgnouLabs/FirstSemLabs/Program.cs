using System;
using System.Linq;

namespace FirstSemLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();

            // Parse input into an array of integers
            int[] numbers = input.Split(' ')
                                 .Where(x => int.TryParse(x, out _))
                                 .Select(int.Parse)
                                 .ToArray();

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            // Perform Bubble Sort
            BubbleSort.Sort(numbers);

            Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
        }
    }
}
