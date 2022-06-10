using System;
using Newtonsoft.Json;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = JsonConvert.SerializeObject("A");
            File.WriteAllText(@$"D:\\kek.txt", json);
        }
    }
}
