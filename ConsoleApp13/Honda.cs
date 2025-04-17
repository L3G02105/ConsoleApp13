using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Honda : Moto, IRace, IService, IMove
    {
        public Honda(string model) : base(model) { }



        public override void ShowInfo()
        {
            Console.WriteLine($"Honda motorcycle model: {Model}");
        }

        public void StartRace()
        {
            Console.WriteLine($"{Model} (Honda) is launching into race!");
        }

        public override void Ignition()
        {
            Console.WriteLine($"{Model}(Honda): Key turned. Engine Start quiety!");
        }

        public void ServiceInfo()
        {
            Console.WriteLine($"{Model} (Honda): Next Service in 6000 km or 6 months.");
        }

        public void Move()
        {
            Console.WriteLine("Honda is moving");
        }
    }
}
