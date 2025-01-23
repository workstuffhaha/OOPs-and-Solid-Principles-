using System;

namespace OOPs.src.DesignPatterns.Behavorial.State_Pattern.GoodSolution;

public class Document
{
    // document class uses polymorphism to delegate any of the state class work 
    public IState State {get; set;}
    public UserRoles CurrentUserRoles {get; set;}

    public Document(UserRoles currentUserRole)
    {
        //what this says is that the new document we create will be in the draft state 
        State = new DraftState(this);
        CurrentUserRoles = currentUserRole;
    }

    public void Publish()
    {
        State.Publish();
    }


}
