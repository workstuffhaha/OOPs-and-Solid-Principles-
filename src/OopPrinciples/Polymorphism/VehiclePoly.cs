using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

public class VehiclePoly
{
    public string Brand{get; set;}
    public string Model {get; set;}
    public int Year{get; set;}

    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Vehicle is stopping");
    }
}