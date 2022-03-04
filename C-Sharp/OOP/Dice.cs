using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class Dice
    {
       public int[] Size { get;protected set; } 
        public int[] FaceValue { get;protected set; }
        public Dice()
        {
          Size = new int[6];
            Size[0] = 0;
            Size[1] = 1;
            Size[2] = 2;
            Size[3] = 3;
            Size[4] = 4;
            Size[5] = 5;
           
             
        }
        public virtual void Roll()
        {
            Console.WriteLine("Rolling for six sided Dice");
        }
    }
}
