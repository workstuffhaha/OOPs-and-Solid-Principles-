using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class OverlayNone : IOverlay
{
    public void Apply()
    {
        System.Console.WriteLine("Not applying an overlay");
    }
}
