using System;

namespace AbstractionDemo
{
    // square class inheriting
    // the Shape class
    class Square : Shape
    {

        // private data member
        private int side;

        // method of  square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
      //  public static void Main(string[] arg)
      //  {
      //      Console.WriteLine("I am in Square main");
       // }
    }
}
