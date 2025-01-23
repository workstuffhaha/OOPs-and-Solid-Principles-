using System;

namespace OOPs.src.DesignPatterns.Behavorial.momento;

public class Editor
{
    public string Title {get; set;}
    public string Content {get; set;}

    public EditorState CreateState()
    {
        // an immutable snapshot 
        //whenever backup is needed, CreateState() is called, and it creates a new EditorState object containing the current state.
        return new EditorState(Title, Content);
    }

    public void Restore(EditorState state)
    {
        //undo operation is performed, the method restores the editors state using a previously saved EditorState.
        Title = state.GetTitle();
        Content= state.GetContent();

    }
}
