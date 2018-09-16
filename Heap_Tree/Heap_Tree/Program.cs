using System;
using System.Collections.Generic;
using System.Text;
namespace Heap_Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            Heap_Tree<int> heap = new Heap_Tree<int>();

            for (int i = 0; i < 20; i++)
            {
                heap.Insert(rand.Next(1, 100));
            }

            while (heap.Count > 0)
            {
                Console.Write($"{heap.Pop()} ");
            }
            Console.ReadKey();
        }
    }
}
