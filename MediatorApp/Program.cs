// See https://aka.ms/new-console-template for more information
using Mediator;

Console.WriteLine("Hello, World!");


User robert = new User("Muhsin");
User john = new User("Cem");


Console.WriteLine(robert.SendMessage("Hello!"));
Console.WriteLine(john.SendMessage("Hi!"));