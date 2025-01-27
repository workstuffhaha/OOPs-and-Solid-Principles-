using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("compressing video using MOV");
    }
}
