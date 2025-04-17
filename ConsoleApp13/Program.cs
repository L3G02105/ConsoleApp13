using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Moto honda = new Honda("CBR600RR");
            Moto bmw = new BMW("S1000RR");

            
            honda.ShowInfo();
            honda.Ignition();
           

            Console.WriteLine();

            bmw.ShowInfo();
            bmw.Ignition();



            Console.WriteLine();

            
            IRace hondaRace = honda as IRace;
            IRace bmwRace = bmw as IRace;

            hondaRace?.StartRace();
            bmwRace?.StartRace();

            Console.WriteLine();

            
            IService hondaService = honda as IService;
            IService bmwService = bmw as IService;

            hondaService?.ServiceInfo();
            bmwService?.ServiceInfo();

            

            IMove hondaMove = honda as IMove;
            IMove bmwMove = bmw as IMove;



            hondaMove?.Move();
            bmwMove?.Move();




            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
