using FactoryDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Services
{
    public class MobilePhoneScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("MobilePhone - Screen");
        }
    }
}
