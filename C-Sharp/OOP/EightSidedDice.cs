using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class EightSidedDice :Dice
    {
        public EightSidedDice()
        {
            Size =new int[8];
            for (int i = 0; i<8; i++)
            {
                Size[i] = i + 1;
            }
        }
        public override void Roll()
        {
            Console.WriteLine("Rolling for eight sided Dice");
        }
    }
}
