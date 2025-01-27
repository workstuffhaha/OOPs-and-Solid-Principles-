using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

public class NewVideoStorage
{
    private ICompressor _compressor;
    private IOverlay _overlay;

    public NewVideoStorage(ICompressor compressors, IOverlay overlay)
    {
        _compressor=compressors;
        _overlay=overlay;
    }

    public void SetCompressor(ICompressor compressors)
    {
        _compressor=compressors;
    }

    public void SetOverlay (IOverlay overlays)
    {
        _overlay=overlays;
    }

    public void Store(string fileName)
    {
       _compressor.Compress();
       _overlay.Apply();

        System.Console.WriteLine($"storing video to file name {fileName}.{_compressor} and overlay {_overlay}");
    }

}
