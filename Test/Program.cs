using System;

namespace Test
{
    struct book
    {
        public string title;
        public string name;
        public string author;
    }
    class Program
    {
        static void Main(string[] args)
        {
            book b;
            b.author = "King";
            Console.WriteLine("Hello World!");
        }
    }
}
