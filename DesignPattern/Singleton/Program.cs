using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singltonIntance = Singleton.Instance;
            Console.WriteLine(singltonIntance.GetType().ToString());
        }
    }
}
