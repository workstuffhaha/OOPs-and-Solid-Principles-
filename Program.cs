//ENCAPSULATION
 

/**using OOPs.src.OopPrinciples.Encapsulation;

BankAccount bankaccount = new BankAccount(-100);

System.Console.WriteLine(bankaccount.GetBalance()); //uses the fully qualified name of the Console class
// dont need to write System if using System is there as the first line of the program

bankaccount.Deposit(50);
System.Console.WriteLine(bankaccount.GetBalance());

bankaccount.WithDrawal(100);
System.Console.WriteLine(bankaccount.GetBalance());

//---------------------------------------


**//**
//ABSTRACTION
//reduce complexity by hidingn unnecessary details

using OOPs.src.OopPrinciples.Abstraction;

EmailService emailService = new EmailService();
//emailService.Connect();
//emailService.Authenicate();
emailService.SendEmail();
//emailService.Disconnet(); 


//---------------------------------------

//INHERITANCE
//involves creating new classes based of existing classes, inherit the properties and behaviours from their superclasses.

**//**

using OOPs.src.OopPrinciples.Inheritance;
//using does not require brackets but a semi colon

    var car = new Car
    {
        Brand = "ford"
    };
    car.Start();
    car.Stop();
    car.NoDoors=4;

//---------------------------------------

//POLYMORPHISM
//overriding happens in this case
//ability of an object to take many forms
//virtual keyword is used to define methods, properties, events or indexers in a base class that can be overridden in a derived class.

**//**
using OOPs.src.OopPrinciples.Inheritance;
using OOPs.src.OopPrinciples.Polymorphism;


List<VehiclePoly> vehicles = new List<VehiclePoly>(); // just a list of objects
vehicles.Add(new CarPoly{Brand="toyota", Model="camry", Year=2020, NoDoors=4});
vehicles.Add(new BikePoly{Brand="harley", Model="sportser", Year=2021, NoWheels=2});

//vehicle inspection 
foreach(var v in vehicles)
{
    v.Start();// polymorphism is applied exactly here
}

//---------------------------------------

**//**
//COUPLING
// the degree of dependency between different classes

using OOPs.src.OopPrinciples.Coupling;

//var order = new Order(new EmailSender());
var order = new Order(new SmsSender());
order.PlaceOrder();

//---------------------------------------

**//**

//COMPOSITION
// involves creating complex objects by combining simpler objects or components. In composition objects are assembled together to form larger structures, with each component object maintaining its own state and behaviour. Composition is often descirbed in terms of "has-a" relationship.

using OOPs.src.OopPrinciples.Composition;

var car = new Car();
car.StartCar();

//---------------------------------------

**//** 
COMPOSITION VS INHERITANCE 

when to use composition : 
1) where you need more flexibility in constructing objects between classes, and a "has-a" relationship is more appropriate.
2) when there is no clear "is-a" relationship between classes, and a "has-a" relationship is more 
3) when you want to avoid the limitations of inheritance, such as tight coupling and the fragile base class problems 

when to use inheritance : 
1) when there is a clear "is-a" relationship between classes, and subclass objects can be treated as instances of their superclass
2) when you want to promote code reuse by inheriting properties and behaviour classes
3) when you want to leverage polymorphism to allow objects of different subclasses to be treated uniformly through their common superclass interface.

//---------------------------------------

**//**

FRAGILE CLASS PROBLEM

1) inheritance coupling : coupling brtween base class and dervied class
2) limited extensibility : brittle software
3) mitigation strategies : to solve design principles like OCP (open closed principle) and dependency inversion principle (DIP). these approached promote loose coupling, encapsulation and modular design, reducing the impact of charges in base classes.

//---------------------------------------

**//**
OPEN CLOSED PRINCIPLE(OCP)

software entities (classes, modules, functions ect) should be open for extension but closed for modification

code extension can be done using inheritance or composition

//---------------------------------------

**//**
LISKOV SUBSTITUITION PRINCIPLE

objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program. 

inheritance heirarchy is well designed

**/

/**

using OOPs.src.SolidPrinciples.LSP;

// var rect = new OOPs.src.SolidPrinciples.LSP.Square();

// rect.Height = 10;
// rect.Width = 5;

// System.Console.WriteLine($"calculated area = {rect.Area}");

Shape rectangle = new OOPs.src.SolidPrinciples.LSP.Rectangle { Width = 5, Height = 4 };
System.Console.WriteLine($"area of the recatangle: {rectangle.Area}");

Shape square = new Square{SideLength=5};
System.Console.WriteLine($"area of the square: {square.Area}");


//hi
**/

//--------------------------------------

/**
INTERFACE SEGREGATION PRINCIPLE (ISP)

clients should not be forced to depend on interfaces they do not use

initially, we made an interface that has area and volume itself 
but say you take an example that you have a class called circle and need to calculate its area
so then, in that case, you implement this interface. but a circle does not have volume, so you get an exception 

this violates the ISP


using OOPs.src.SolidPrinciples.ISP;
var circle = new Circle();
circle.Raidus=10;
System.Console.WriteLine(circle.Area());

**/

//--------------------------------------

/**
DEPENDENCY INVERSION PRINCIPLE

high level modules should not depend on low level modules, both should depend on abstraction

using OOPs.src.SolidPrinciples.DIP;
var car = new Car(new Engine());
// this is called dependency injection, where we inject the dependency into the class
car.StartCar();

high level module : car( has a broader scope, coordinating more things)
low level abstraction/module : engine

**/

