using System;

namespace OOPs.src.SolidPrinciples.OCP;

public class Circle : Shape
{
    public double Radius{get; set;}
    public override double CalculateArea()
    {
        return Math.PI*Math.Pow(Radius,2);
    }
}
