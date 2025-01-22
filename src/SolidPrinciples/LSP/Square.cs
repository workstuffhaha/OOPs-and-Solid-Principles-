using System;

namespace OOPs.src.SolidPrinciples.LSP;

public class Square : Shape
{
    public double SideLength{get; set;}

    public override double Area => SideLength*SideLength;
}