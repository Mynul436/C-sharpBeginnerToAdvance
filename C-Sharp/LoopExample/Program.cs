// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] marks = new int[] { 10, 20, 30, 40, 50 };
//double average = (marks[0] + marks[1] + marks[2] + marks[3] + marks[4]) / 5;
int sum = 0;
for (int i = 0; i < marks.Length; i++) 
{
    sum+= marks[i];

}
Console.WriteLine(sum);

int num = 100;
while (num > 0)
{
    num /= 2;
    Console.WriteLine($"From while loop {num}");
}
foreach (int i in marks)
{
    Console.WriteLine(i);
}