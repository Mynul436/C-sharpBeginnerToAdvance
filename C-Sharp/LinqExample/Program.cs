

string[] names = { "Mynul","Akash","Soad","Kanon","John" };

var linqName=from name in names where name.Contains('M') select name;
var linqName2=from name in names where name.Contains('s') select name;

foreach (var item in linqName)
{
    Console.WriteLine(item +" ");
}
foreach(var item in linqName2)
{
    Console.WriteLine(item + " ");
}