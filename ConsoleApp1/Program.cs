using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] my_array = new int[8, 8];

            for (int i = 0; i < my_array.GetLength(0); i++)
            {
                for (int j = 0; j < my_array.GetLength(1); j++)
                {
                    int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

                }
            }
        }
    }
}
