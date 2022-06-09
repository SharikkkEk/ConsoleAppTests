using System;
using System.IO;
using System.Collections.Generic;

namespace ConsoleAppTests
{
    struct test
    {
        int test_count_questions;
    }
    class Program
    {
        public static List<string> Test = new List<string>();
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Введите 1, если хотите создать тест,  или введите 2, если хотите пройти тест");
            try 
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    CreateTest();
                }
                else if (a == 2)
                {
                    PassTest();
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
        }
        static void CreateTest()
        {

        }
        static void PassTest()
        {

        }
    }
}
