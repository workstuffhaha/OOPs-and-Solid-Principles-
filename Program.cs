/** using OOPs.src.DesignPatterns.Behavorial.momento;

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

**/

//--------------------------------------

// STATE PATTERN

/**
using System.Reflection.Metadata;
using OOPs.src.DesignPatterns.Behavorial.State_Pattern;

var doc = new OOPs.src.DesignPatterns.Behavorial.State_Pattern.Document();

doc.State = DocumentStates.Moderation;
doc.CurrentUserRole = UserRoles.Editor;
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);

**/
/**
using OOPs.src.DesignPatterns.Behavorial.State_Pattern;

//here new document is created, it is in draft state
var doc = new OOPs.src.DesignPatterns.Behavorial.State_Pattern.GoodSolution.Document(OOPs.src.DesignPatterns.Behavorial.State_Pattern.GoodSolution.UserRoles.Admin); //user role of the document is an Editor

System.Console.WriteLine(doc.State);
doc.Publish();

System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);

**/

//----------------------------------------

//STRATEGY PATTERN 

using OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern;
using OOPs.src.DesignPatterns.Behavorial.Strategy_Pattern.GoodSolution;

var videoStore = new NewVideoStorage(new CompressorMOV(), new OverlayBW());
videoStore.Store("/videos/some-movie");

// because we added setter methods, that allows us to change the storage way or the overlay method. we do not have to create a new object of the class NewVideoStorage for a different compressor.

videoStore.SetCompressor(new CompressMP4());
videoStore.SetOverlay(new OverlayNone());
videoStore.Store("/videos/updated-movie");