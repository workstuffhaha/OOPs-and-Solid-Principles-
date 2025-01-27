using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class OverlayBlur : IOverlay
{
    public void Apply()
    {
        System.Console.WriteLine("apllying blur overlay");
    }
}
