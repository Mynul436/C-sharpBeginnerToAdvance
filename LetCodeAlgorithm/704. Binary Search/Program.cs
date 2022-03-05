int num;
num=Convert.ToInt32( Console.ReadLine());
int[] input=new int[num];

for(int i=0; i<num; i++)
{
    input[i]=Convert.ToInt32(Console.ReadLine());
}
Array.Sort(input);
/*
foreach (int item in input)
{
    Console.WriteLine(item);
}
*/
int target;
target=Convert.ToInt32( Console.ReadLine());

int res = Array.BinarySearch(input, target);
if (res < 0)
    Console.WriteLine(-1);
else
    Console.WriteLine(res);

