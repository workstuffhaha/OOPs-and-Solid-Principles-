using System;

namespace OOPs.src.DesignPatterns.Behavorial.State_Pattern.GoodSolution;

public class PublishedState : IState
{
    private Document _document;
    public PublishedState (Document document)
    {
        _document=document;
    }
    public void Publish()
    {
        return; // do nothing if already in published state
    }
}
