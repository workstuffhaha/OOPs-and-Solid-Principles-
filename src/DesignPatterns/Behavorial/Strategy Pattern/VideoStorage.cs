using System;

namespace OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern;

public class VideoStorage
{
    private Compressors _compressor;
    private Overlays _overlay;

    public VideoStorage(Compressors compressors, Overlays overlay = Overlays.None)
    {
        _compressor=compressors;
        _overlay=overlay;
    }

    public void SetCompressor(Compressors compressors)
    {
        _compressor=compressors;
    }

    public void SetOverlay (Overlays overlays)
    {
        _overlay=overlays;
    }

    public void Store(string fileName)
    {
        if(_compressor == Compressors.MOV)
        {
            System.Console.WriteLine("compressing using MOV");

        } else if (_compressor==Compressors.MP4)
        {
            System.Console.WriteLine("compressing using MP4");
        }
        else if (_compressor==Compressors.WEBM)
        {
            System.Console.WriteLine("compressing using webm");
        }


        if(_overlay==Overlays.BlackAndWhite)
        {
            System.Console.WriteLine("applying b&w");
        } else if (_overlay==Overlays.Blur)
        {
            System.Console.WriteLine("applying blur");
        } else if(_overlay == Overlays.None)
        {
            System.Console.WriteLine("not applying an overlay");
        }

        System.Console.WriteLine($"storing video to file name {fileName}.{_compressor} and overlay {_overlay}");
    }

    


}
