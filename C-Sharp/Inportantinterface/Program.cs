//IEnumerable<int> list=new List<int>();  
using Inportantinterface;

List<int> list = new List<int>();
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
foreach (var item in list)
{
    Console.WriteLine(item);
}
Box box = new Box();
foreach (var item in box)
{
    Console.WriteLine(item);
}