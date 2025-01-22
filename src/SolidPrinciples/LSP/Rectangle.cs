using System;

namespace OOPs.src.SolidPrinciples.LSP;

public class Rectangle : Shape
{

    //in this case the superclass is rectangle and the subclass is square 
    //and so the objects of superclass are replacable by the objects subclass
    public virtual double Width{get; set;}
    public virtual double Height{get; set;}

    public override double Area => Width*Height;

}
