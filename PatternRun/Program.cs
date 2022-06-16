// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");


IShape? circle = ShapeFactory.GetShape(ShapeType.Circle);


Console.WriteLine(circle?.Draw());
IShape? rectangle = ShapeFactory.GetShape(ShapeType.Rectangle);
Console.WriteLine(rectangle?.Draw());

IShape? square = ShapeFactory.GetShape(ShapeType.Square);
Console.WriteLine(square?.Draw());
