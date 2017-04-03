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
            var zoo = new Zoo<Horse>();
            var h = new Horse("Mooool");
            var man = new Manager();
            var doc = new Doctor();
            zoo.Doctor = doc;
            zoo.Manager = man;

            zoo.CreateInstance(h);

            h.OnHungry(3);
            zoo.Doctor.VoxInvoke();
            Console.ReadKey();
        }
    }
}
