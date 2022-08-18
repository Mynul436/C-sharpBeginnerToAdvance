using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Serialozation_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Serialization
            //string path = @"E:\Dev Skill\C-sharpBeginnerToAdvance\C-Sharp\sample.pnj";

            //Employee emp = new Employee(123, "Mynul");
            //FileStream fl =new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter bf =new BinaryFormatter();
            //bf.Serialize(fl, emp); 
            //fl.Close();
            //Console.WriteLine("File created successfully! "+path);
            //Console.ReadLine();

            //Deserialization
            string path = @"E:\Dev Skill\C-sharpBeginnerToAdvance\C-Sharp\sample.pnj";
            FileStream fl = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp =(Employee)bf.Deserialize(fl);
            Console.WriteLine($"Name is {emp.name} and id is {emp.id}");
            fl.Close();
            Console.ReadKey();
            
            



        }
    }
}
