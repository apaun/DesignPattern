using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _syncRoot = new object();

        private Singleton()
        { }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_syncRoot)
                    {
                        if(_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
