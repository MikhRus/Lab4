using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Zoo <T> where T : Animal, IAnimal, IHomeAnimal, new()
    {

        private List <T> _animals  = new List<T>();    
        public Manager Manager { get; set; } = new Manager();
        public void CreateInstance()
        {
            T animal = new T();
            //animal.IAmHungry+=
            _animals.Add(animal);
        }
    }

    public class Manager
    {
        public void OnHungry(object sender, HungryEventArgs args)
        {
            Console.WriteLine($"Я несу тебе корм {args.CountFood}");
        }

    }
}
