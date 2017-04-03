using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Horse("Moooool");
            Console.WriteLine(horse.Name);
            Console.ReadKey();
        }
    }
}
