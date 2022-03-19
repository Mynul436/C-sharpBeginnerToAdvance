using System;

namespace AbstractionDemo
{
    // Driver Class
    class GFG
    {

        // Main Method
        static void Main(string[] args)
        {

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(5);

            // calling the method
            double result = sh.area();

            Console.WriteLine("{0}", result);

        }
    }
}
