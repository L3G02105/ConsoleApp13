using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    abstract class Moto
    {
        public string Model { get; }

        public Moto(string model)
        {
            Model = model;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Moto model: {Model}");
        }

        public abstract void Ignition();

    }
}

