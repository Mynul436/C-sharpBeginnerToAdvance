using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonClass
    {
        private SingletonClass() { }
        public static SingletonClass Instance;
        public static SingletonClass GetInstance()
        {
            if (Instance == null)
                Instance = new SingletonClass();
            return Instance;
        }
    }
}
