using System;

namespace ConsoleAppTests
{
    class Program
    {
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

                }
                else if (a == 2)
                {

                }
            }
            catch
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
        }
    }
}
