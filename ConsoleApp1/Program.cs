using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my_array = new int[2, 2];

            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    Console.WriteLine($"Y: {i} X: {j}");
                    my_array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int y = 0; y < my_array.GetLength(0); y++)
            {
                for (int x = 0; x < my_array.GetLength(1); x++)
                {
                    Console.Write(my_array[y, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
