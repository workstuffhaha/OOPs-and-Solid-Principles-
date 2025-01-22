using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs.src.OopPrinciples.Inheritance
{
    public class Vehicle 
    {
        //something called non-nullable reference types i.e, string, objects etc
        //they can not hold the null value until and unless explicitly specified using a ?
        //public string? name{get; set;}

        public string Brand{get; set;}
        public string Model{get; set;}

        //basically you can not initialize an object for the class Vehicle since this particular class variable is a non-nullable reference type
        public int Year{get; set;}

        public void Start()
        {
            Console.WriteLine("Vehicle is starting"); // check how can you display the type of object over here
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }
    }
}