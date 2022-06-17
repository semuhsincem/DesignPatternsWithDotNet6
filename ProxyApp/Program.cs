// See https://aka.ms/new-console-template for more information
using Proxy;

Console.WriteLine("Hello, World!");

// Create math proxy
MathProxy proxy = new MathProxy();
// Do the math
Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
// Wait for user
Console.ReadKey();