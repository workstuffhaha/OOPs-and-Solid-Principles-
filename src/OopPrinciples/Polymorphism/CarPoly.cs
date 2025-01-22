using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace OOPs.src.OopPrinciples.Polymorphism
{
    public class CarPoly : VehiclePoly
    {
        //public int NoDoors{get; set;}
        //2 ways to set a value for this

        //first is to
        //public int NoDoors{get; set;} =4;
        //second
        //public CarPoly()
        //{ NoDoors =4 ; }

        public int NoDoors{get; set;}=4;
        public override void Start()
        {
            Console.WriteLine("car is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("car is stopping");
        }
    }
}