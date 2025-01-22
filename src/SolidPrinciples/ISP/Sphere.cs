using System;

namespace OOPs.src.SolidPrinciples.ISP;

public class Sphere : IShape3D
{
    public double Raidus;
    public double Area()
    {
        return 4*Math.PI*Math.Pow(Raidus,2);
    }

    public double Volume()
    {
        return (4/3)*Math.PI*Math.Pow(Raidus,3);
    }
}
