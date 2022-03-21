using StaticClass;

Waterbottle bottle1 = new Waterbottle();
bottle1.color = "red";
Waterbottle.count++;
Waterbottle bottle2 = new Waterbottle();
Waterbottle.count++;
Console.WriteLine(Waterbottle.count);
Console.WriteLine(555);