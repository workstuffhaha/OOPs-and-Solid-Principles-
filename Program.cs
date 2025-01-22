using OOPs.src.DesignPatterns.Behavorial.momento;

var editor = new Editor();
var history = new History(editor);
history.Backup(); // backing up a blank editor
editor.Title = "test";
history.Backup();
editor.Content="hello there, my name is workstuffhaha";
history.Backup();
editor.Title="my memento";
//history.Backup();

System.Console.WriteLine($"title : {editor.Title}");
System.Console.WriteLine($"content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"title : {editor.Title}");
System.Console.WriteLine($"content: {editor.Content}");



//history.ShowHistory();

history.Undo();

System.Console.WriteLine($"title : {editor.Title}");
System.Console.WriteLine($"content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"title : {editor.Title}");
System.Console.WriteLine($"content: {editor.Content}");