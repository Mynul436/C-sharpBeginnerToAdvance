

string match =@"E:\Dev Skill\Data.txt";

if(File.Exists(match))
{
    Console.WriteLine("THE FILE EXIST..");
    string path=File.ReadAllText(match);
    Console.WriteLine(path);

    string match2 = @"E:\Dev Skill\Data2.txt";
    File.Copy(match, match2);
}
else
{
    Console.WriteLine("Does not exist");
}