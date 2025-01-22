using System;

namespace OOPs.src.SolidPrinciples.OCP;

public abstract class Shape
{
    // initially this class had all properties and a switch statement that would calculate the area for you

   //by creating abstract classes and methods, other classes can extend and implement the methods. there will be no need to modify this base class
   
    public abstract double CalculateArea();

}
