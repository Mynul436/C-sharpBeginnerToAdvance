using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.RealWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList studentsRecords = new SortedList();
            studentsRecords.Add("Samiul");
            studentsRecords.Add("Mynul");
            studentsRecords.Add("Akash");

            studentsRecords.SetSortStrategy(new QuickSort());
            studentsRecords.Sort();

            studentsRecords.SetSortStrategy(new MergeSort());
            studentsRecords.Sort();



        }
    }
}
