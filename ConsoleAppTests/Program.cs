using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace ConsoleAppTests
{
    class Program
    {
        
        public struct test_element
        {
            public string questions_name;
            public string questions_1_variant;
            public string questions_2_variant;
            public int questions_true_variant;
        }
        string quest = "21";
        public static List<test_element> Test = new List<test_element>();
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
            Console.WriteLine("Введите количество вопросов в тесте"); 
            try
            {
                int questions_count = int.Parse(Console.ReadLine());
                for (int i = 0; i < questions_count; i++)
                {
                    CycleGenerateTest();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не число");
            }

            string Json = JsonConvert.SerializeObject(Test);
            File.WriteAllText($@"D:\\{test_name}.txt", Json);
            Menu();
        }

        static void PassTest() // В этой функции я буду загружать переменные и списки из файла json
        {

        }

        static void CycleGenerateTest()
        {
            test_element a = new test_element();

            Console.WriteLine("Введите название вопроса");
            a.questions_name = Console.ReadLine();

            Console.WriteLine("Введите первый вариант ответа");
            a.questions_1_variant = Console.ReadLine();

            Console.WriteLine("Введите второй вариант ответа");
            a.questions_2_variant = Console.ReadLine();

            Console.WriteLine("Введите номер правильного варианта ответа"); 
            a.questions_true_variant = int.Parse(Console.ReadLine());

            if (a.questions_true_variant != 1 && a.questions_true_variant != 2)
            {
                Console.WriteLine("Ошибка, ввели не число 1 или 2");
                Menu();
            }

            Test.Add(a);
        }
    }
}

