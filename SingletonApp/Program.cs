// See https://aka.ms/new-console-template for more information
using Singleton;

//Get the only object available
SingleObject object1 = SingleObject.getInstance();

//show the message
Console.WriteLine(object1.showMessage());