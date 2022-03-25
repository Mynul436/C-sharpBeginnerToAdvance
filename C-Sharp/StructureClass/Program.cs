// See https://aka.ms/new-console-template for more information
using StructureClass;

Console.WriteLine("Hello, World!");
Product p1 = new Product();
p1.Name = "Botanic Aroma";
p1.Description = "Cream";
Console.WriteLine(p1.Name+ " "+p1.Description);
Product p2 = p1;
Console.WriteLine(p2.Name+" "+p2.Description);
p2.Name = "Energy";
p2.Description = "Biscuit";
Console.WriteLine(p1.Name + " " + p1.Description);
Console.WriteLine(p2.Name + " " + p2.Description);

