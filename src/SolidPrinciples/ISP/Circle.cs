using System;

namespace OOPs.src.SolidPrinciples.ISP;

public class Circle : IShape2D
{
    public double Raidus {get; set;}

    public double Area()
    {
        return Math.PI*Raidus*Raidus;
    }
}
