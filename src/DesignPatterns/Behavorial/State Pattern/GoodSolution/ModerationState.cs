using System;

namespace OOPs.src.DesignPatterns.Behavorial.State_Pattern.GoodSolution;

public class ModerationState : IState
{
    private Document _document;

    public ModerationState(Document document)
    {
        _document=document;
    }

    public void Publish()
    {
        // If the state is moderation then you have to check the current user role 

        // if admin then the state is updated to publish 
        // else we dont do anything 

        if(_document.CurrentUserRoles== UserRoles.Admin)
        {
            _document.State= new PublishedState(_document);
        }
    }
}
