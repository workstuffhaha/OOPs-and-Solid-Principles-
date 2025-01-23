using System;
using System.Runtime.CompilerServices;

namespace OOPs.src.DesignPatterns.Behavorial.momento;

public class EditorState
{
    //memento
    // once the editor state is created, it shouldnt be able to edit it, should be constant

    // represents a snapshot of the Editor's state.

    // editorstate is immutable and cnnot be altered once created.

    private readonly string _title;
    // immutable because readonly file
    private readonly string _content;

    //state meta data 

    private readonly DateTime _StateCreatedAt;
    public EditorState(string title, string content)
    {
        _title=title;
        _content=content;
        _StateCreatedAt=DateTime.Now;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetContent()
    {
        return _content;
    }

    public DateTime GetDate()
    {
        return _StateCreatedAt;
    }

    public string GetName()
    {
        return $"{_StateCreatedAt} / {_title}";
    }

}
