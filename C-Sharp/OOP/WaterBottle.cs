using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class WaterBottle
    {
        string color;
        double capacity;
        double height;
        bool capOpen;
        double content;
        public string Color
        {
            get 
            { 
                return color; 
            }
        }
        public WaterBottle()
        {
            color ="blue";
            capacity =1000;
            height =300.5;
            capOpen = false;    
            content =  0;
        }
        public WaterBottle(string color, double capacity, double height)
        {
            this.color = color;
            this.capacity = capacity;
            this.height = height;

        }

     public   void OpnenCap()
        {
            capOpen = true;
        }
      public  void CloseCap()
        {
            capOpen=false;
        }
       public void AddWater(double amount)
        {
            if(content+amount > capacity) 
                content = amount;   
            else
                content+=amount;
        }
       public void RemoveWater(double amount)
        {
            if(content-amount<0)
                content = 0;
            else
	{
             content -= amount;
	}
        }
    }
}
