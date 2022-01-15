using System;
using System.Collections.Generic;

namespace _01_04_single_pop
{
    class Program
    {
        static void Main()
        {
            // 入力
            int n = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                queue.Enqueue(value);
            }

            // Dequeue
            queue.Dequeue();

            // 出力
            Console.WriteLine(String.Join("\n", queue));
        }
    }
}