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
                    Menu();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное значение");
                Menu();
            }
        }

        public static void CreateTest()
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
                Menu();
            }

            string Json = JsonConvert.SerializeObject(Test);
            Directory.CreateDirectory("C:\\Tester\\");
            File.WriteAllText($@"C:\\Tester\\{test_name}.txt", Json);
            Menu();
        }

        static void PassTest() // В этой функции я буду загружать переменные и списки из файла json
        {
            int points = 0;
            Console.WriteLine("Введите название теста");
            string test_name_1 = Console.ReadLine();
            List<test_element> loaded_test = JsonConvert.DeserializeObject<List<test_element>>(File.ReadAllText($"D:\\{test_name_1}.txt"));
            for (int i = 0; i < loaded_test.Count; i++)
            {
                Console.WriteLine($"Вопрос {i+1}: {loaded_test[i].questions_name}");
                Console.WriteLine($"Первый вариант ответа - {loaded_test[i].questions_1_variant}, Второй вариант ответа - {loaded_test[i].questions_2_variant}");
                Console.Write("Ваш ответ - ");
                int otvet = int.Parse(Console.ReadLine());
                if (otvet != 1 && otvet != 2)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                    Menu();
                }
                if (otvet == loaded_test[i].questions_true_variant)
                {
                    points++;
                    Console.WriteLine("Верно");
                }
                else
                {
                    Console.WriteLine("Неверно");
                }
            }
            Console.WriteLine($"Вы ответили правильно на {points} вопросов из {loaded_test.Count}");
            Menu();
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

