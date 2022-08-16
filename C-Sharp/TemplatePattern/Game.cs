using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class Game
    {
        abstract public void InitialPlay();
        abstract public void StartPlay();
        abstract public void StopPlay();
        public void  Play()
        {
            InitialPlay();
            StartPlay();
            StopPlay();
        }
    }
}
