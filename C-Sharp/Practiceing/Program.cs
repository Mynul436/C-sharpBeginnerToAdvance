using System;
public class c1
{
    enum month
    {
        jan,feb,march,april
    }
   static int a = 10;
    String name;
    int year;
  //  int month;
    int day;
    int age;


    c1(String name,int age,int day)
    {
        this.name = name;
      //  this.year = year;    
        this.day = day;
        this.age = age;
        
    }
    public void Method()
    {
        Console.WriteLine(name);

        Console.WriteLine(year);
        Console.WriteLine(day);
        Console.WriteLine(age);
    }
    public static void Main(String[] args)
    {
        Console.WriteLine((int)month.jan);
        Console.WriteLine(a);
        c1 obj = new c1("Mynul", 22, 2);
        obj.Method();
    }
}