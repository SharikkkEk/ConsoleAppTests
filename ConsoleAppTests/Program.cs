using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ConsoleAppTests
{
    class Program
    {
        public static List<string> test = new List<string>();
        public static List<string> questions_name = new List<string>();
        public static List<string> questions_1_variant = new List<string>();
        public static List<string> questions_2_variant = new List<string>();
        public static List<string> questions_true_variant = new List<string>();
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
            Console.WriteLine("Введите название теста");
            string test_name = Console.ReadLine();
            Console.WriteLine("Введите количество вопросов в тесте"); // Добавить ошибку при вводе не чисел
            int questions_count = int.Parse(Console.ReadLine());
            for (int i = 0; i < questions_count; i++)
            {
                Console.WriteLine("Введите название вопроса");
                questions_name.Add(Console.ReadLine());
                Console.WriteLine("Введите первый вариант ответа");
                questions_1_variant.Add(Console.ReadLine());
                Console.WriteLine("Введите второй вариант ответа");
                questions_2_variant.Add(Console.ReadLine());
                Console.WriteLine("Введите номер правильного варианта ответа"); // Добавить ошибку при != 1, 2
                questions_true_variant.Add(Console.ReadLine());
            }
        }
        static void PassTest() // В этой функции я буду загружать переменные и списки из файла json
        {
        }
    }
}
