using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Cricket : Game
    {
        public override void InitialPlay()
        {
            Console.WriteLine("Start Play 1");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Start Play 2");
        }

        public override void StopPlay()
        {
            Console.WriteLine("Start Play 3");
        }
    }
}
