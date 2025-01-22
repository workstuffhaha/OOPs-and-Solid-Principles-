using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs.src.OopPrinciples.Polymorphism
{
    public class BikePoly : VehiclePoly
    {
        public int NoWheels{get;set;}
        public override void Stop()
        {
            Console.WriteLine("bike is stopping");
        }
        public override void Start()
        {
            Console.WriteLine("bike is starting");
        }
    }
}