using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class OverlayBW : IOverlay
{
    public void Apply()
    {
        System.Console.WriteLine("apllying black and white overlay");
    }
}
