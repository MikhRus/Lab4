﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HungryEventArgs:EventArgs
    {
        public bool IsMeat { get; set; }
        public int CountFood { get; set; }
    } 

    public interface IAnimal
    {
       string Name { get; set; }
    }

    public interface IHomeAnimal
    {
        event HungryHandler IAmHungry;
        void OnVox(object sender, EventArgs args);
    }

    public delegate void HungryHandler(object sender, HungryEventArgs args);

    public abstract class Animal:IAnimal,IHomeAnimal
    {
        public string Name { get; set; }
        public abstract event HungryHandler IAmHungry;
        public abstract void OnVox(object sender, EventArgs args);
    }

    public class Horse:Animal
    {
        //public Horse() { }

        public Horse(string name)
        {
            Name = name;
        }
        public override event HungryHandler IAmHungry;

        public void OnHungry(int count)
        {
            IAmHungry?.Invoke(this, new HungryEventArgs{ IsMeat = false, CountFood = count });
        }

        public override void OnVox(object sender, EventArgs args)
        {
           Console.WriteLine("Ok, I'm ready");
        }
    }
}
