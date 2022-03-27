
using FactoryPattern;

Console.WriteLine("Enter your object Type: ");
string type=Console.ReadLine();
Interface1 obj=CreateObject.getObject(type);
Console.WriteLine(obj.getName());