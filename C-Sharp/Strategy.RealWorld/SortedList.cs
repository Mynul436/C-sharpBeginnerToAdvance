using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.RealWorld
{
    public class SortedList
    {
        private List<string> list=new List<string>(); 
        private IStrategy _istrategy;

        public void Add(string name)
        {
            list.Add(name);
        }
        public void SetSortStrategy(IStrategy strategy)
        {
            _istrategy = strategy;
        }
        public void Sort()
        {
            _istrategy.Sort(list);
            foreach (var name in list)
            {
                Console.WriteLine(" "+name);
            }
            Console.WriteLine();
        }

    }
}
