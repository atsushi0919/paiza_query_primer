using System;

namespace _03_06_test
{
    class Program
    {
        static void Main()
        {
            int SIZE = 10000;
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] results = new int[k];
            for (int i = 0; i < k; i++)
            {
                string[] input = Console.ReadLine().Split();
                int l = int.Parse(input[0]);
                int r = int.Parse(input[1]);
                int maxValue = -100001;
                for (int j = l - 1; j < r; j++)
                {
                    maxValue = Math.Max(maxValue, array[j]);
                }
                results[i] = maxValue;
            }
            Console.WriteLine(String.Join("\n", results));
        }
    }
}
