using System;

namespace SingletonDesignPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SingletonDesignPattern instance1 = SingletonDesignPattern.SingletonDesignPatternInstance;
            SingletonDesignPattern instance2 = SingletonDesignPattern.SingletonDesignPatternInstance;

            if (instance1 == instance2)
            {
                Console.WriteLine("Both objects have the same instance");
            }

            Console.ReadKey();
        }
    }
}
