using System;

namespace OOPs.src.DesignPatterns.Behavorial.State_Pattern.Overkill;

public class Stopwatch
{
    private bool IsRunning {get; set;} = false;

    public void Click()
    {
        if(IsRunning)
        {
            IsRunning=false;
            System.Console.WriteLine("stopped");

        }
        else
        {
            IsRunning=true;
            System.Console.WriteLine("running");
        }
        
    }
    

}
