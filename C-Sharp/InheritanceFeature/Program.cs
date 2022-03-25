using InheritanceFeature;

Console.WriteLine("hello");
Product p1=new Product();
Product p2= new  Electronics();
Electronics p3=new Electronics();
p3.num =10;
p3.id = 10;

//p1.price = 200;
p2.price = 200;
p3.price = 200;
//p1.CalculateDiscount(20);
Console.WriteLine(p1.CalculateDiscount(20));
Console.WriteLine(p2.CalculateDiscount(20));
Console.WriteLine(p3.CalculateDiscount(30));