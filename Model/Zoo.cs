using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Zoo <T> where T : Animal
    {

        private List <T> _animals  = new List<T>();    
        public Manager Manager { get; set; }
        public Doctor Doctor { get; set; }
        public void CreateInstance(T animal)
        {
            //T animal = new T();
            animal.IAmHungry += Manager.OnHungry;
            Doctor.Vox += animal.OnVox;
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

    public class Doctor
    {
        public event EventHandler Vox;

        public void VoxInvoke()
        {
            Vox?.Invoke(this, EventArgs.Empty);
        }
    }
}
