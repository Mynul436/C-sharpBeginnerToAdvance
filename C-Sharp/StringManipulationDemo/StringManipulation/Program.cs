using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine();
            //stringConversion();
            //Console.WriteLine();
            //stringEscape();
            //AppendString();
            OrderingString();
        }
        private static void stringConversion()
        {
            string abc = "This is POlice calling";
            TextInfo curentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine(abc.ToUpper());
            string result = curentTextInfo.ToTitleCase(abc);
            Console.WriteLine(result);

        }
        private static void stringEscape()
        {
            string a = "helloo there \\\\ back slash";
            string b = @"hello \\\ brother...";
            Console.WriteLine(b);
        }
        private static void AppendString()
        {
            string fn = "Mynul";
            string ln = "Islam";
            string r = string.Format("My name is {0} {1}", fn, ln);
            Console.WriteLine(r);
            r =$"Hey my name is {fn} {ln}";
            Console.WriteLine(r);
            Stopwatch stop =new Stopwatch();
        }
        private static void OrderingString()
        {

        }
        private static void CompareToHelper(string testA,string testB)
                {


                }
    }
}
