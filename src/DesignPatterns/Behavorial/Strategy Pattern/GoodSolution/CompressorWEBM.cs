using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class CompressorWEBM : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("compressing video using WEBM");
    }
}
