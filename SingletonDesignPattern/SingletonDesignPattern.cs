using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SingletonDesignPattern
    {
        private static SingletonDesignPattern _singletonDesignPattern;
        private static object _lockObject = new();
        private SingletonDesignPattern()
        {
        }
        public static SingletonDesignPattern SingletonDesignPatternInstance
        {
            get
            {
                if (_singletonDesignPattern == null)
                {
                    lock (_lockObject)
                    {
                        if (_singletonDesignPattern == null)
                        {
                            _singletonDesignPattern = new SingletonDesignPattern();

                        }
                    }
                }
                return _singletonDesignPattern;
            }
        }
    }
}
