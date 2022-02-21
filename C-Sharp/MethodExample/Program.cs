// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int [] marks=new int [] {10,20,30,40,50};
//double average=(marks[0]+marks[1]+marks[2]+marks[3]+marks[4])/5;
double average = CalculateMarks(marks);
Console.WriteLine(average);

double CalculateMarks(int [] marks) {
    int sum = 0;
    foreach (int mark in marks) { 
    sum+=mark;
    }
    return sum;
}
