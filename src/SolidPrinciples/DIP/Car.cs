using System;
using OOPs.src.OopPrinciples.Composition;

namespace OOPs.src.SolidPrinciples.DIP;

public class Car
{
    // the car class has a direct dependency on the Engine class

    // car class directly creates and instance of the engine class, leading to tight coupling
    // so if the engine class changes, then it effects the car class, and that violates the dependency inversion princple

    // so to solve this, we can introduce an abstraction between the car and engine. allowing the car to depend on that 

    // so here since an interface is used, we can have different types of engines that implement the interface. 
    // you could have an electricEngine also and stuff 
    private IEngine engine;
    public Car(IEngine engine)
    {
        this.engine= engine;
    }

    public void StartCar()
    {
        engine.Start();
        System.Console.WriteLine("CAR STARTED");
    }
}
