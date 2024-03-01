
using Tasc3;

var dog=new Dog("");
System.Console.Write("Name : ");
dog.SetName(Console.ReadLine());
System.Console.WriteLine(dog.GetName());
dog.Eat();