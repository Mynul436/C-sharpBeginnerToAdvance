using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
        }
    }
}
