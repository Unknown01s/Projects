// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 0, 0, 0 };
            int i = 0, n = 0;

            for (int j = 0; j <= numbers.Length; j++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                n = int.Parse(Console.ReadLine());

                if (n < 10 || n > 100)
                {
                    Console.WriteLine("Enter number between 10 and 100");
                    --j;
                    continue;
                }
                else if (contains(n, numbers))
                    Console.WriteLine("This number already in array");
                else if (i == numbers.Length)
                    break;
                else
                {
                    numbers[i++] = n;
                    printArray(numbers);
                    Console.WriteLine();
                }
            }

            if (i == numbers.Length && n != numbers[numbers.Length - 1])
            {
                printArray(numbers);
                Console.Write($" {n}\n");
            }

            Console.Write("Goodbye!");

            Console.Read();
        }

        static bool contains(int num, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == num)
                    return true;

            return false;
        }

        static void printArray(int[] nums)
        {
            Console.Write("Unique values:");

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == 0) break;
                else Console.Write(" {0}", nums[i]);
        }
    }
}

