using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class CompressMP4 : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("compressing video using MP4");
    }

    

}
