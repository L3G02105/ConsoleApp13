using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class BMW : Moto, IRace, IMove, IService

    {
        public BMW(string model) : base(model) { }



        public override void ShowInfo()
        {
            Console.WriteLine($"BMW motorcycle model: {Model}");
        }

        public void StartRace()
        {
            Console.WriteLine($"{Model} (BMW) is launching into race!");
        }

        public override void Ignition()
        {
            Console.WriteLine($"{Model}(BMW): Button pressed. Engine roars to Life!");
        }

        public void ServiceInfo()
        {
            Console.WriteLine($"{Model} (BMW): premium srvice required every 8000km or once a year");
        }

        public void Move()
        {
            Console.WriteLine("BMW is moving");
        }
    }
}
