//using is a directive (special instruction given to the compiler about how to process the code)
using System;
// the System namespace includes types like string, int, double, DateTime
// Console.WriteLine also
// exception classes like Exception, InvalidOperationException
using System.Collections.Generic;
// provides access to generic collections like List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>
//enables type-safe, resuable data structures that can work with any type
using System.Linq;
//provides access to LINQ, makes working with collections easier, mroe readable
using System.Threading.Tasks;
//enables asynchronous programming using Task and task<T>
//improves responsiveness in apps by freeing up the main thread for other tasks.

namespace OOPs.src.OopPrinciples.Inheritance
{
    public class Car : Vehicle
    {
        public int NoDoors{get; set;}
        public int NoWheel{get; set;}
    }
}