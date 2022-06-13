using System;
using System.Collections.Generic;
using System.Linq;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my_array = new int[10,6];
            Random random = new Random();

            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    my_array[i, j] = random.Next(0, 10);
                }
            }
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