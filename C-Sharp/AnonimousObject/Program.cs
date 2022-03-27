
object o = new { Name = "Mynul", Age = "22" };
dynamic d = o;
Console.WriteLine(d.Name);

(string name1, string name2)[] arr = new (string name1, string name2)[3];
//arr[0] = ("mynul", "akash");
Console.WriteLine();
//arr[1] = ("Soad", "Kanon");
//arr[2] = ("sadnan", "subha");
//Console.WriteLine(arr[1]);
string[] str = new string[3];
for (int i = 0; i < str.Length; i++)
{
    str[i] = Console.ReadLine();
}
string[] str1 = new string[3];
for (int i = 0; i < str1.Length; i++)
{
    str1[i] = Console.ReadLine();
}
for (int i = 0; i < arr.Length; i++)
{
   // Console.WriteLine(arr[i]);
  arr[i] =(str[i] , str1[i]);
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}