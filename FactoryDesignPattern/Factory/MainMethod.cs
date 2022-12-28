using FactoryDesignPattern.Abstract;
using FactoryDesignPattern.Enum;
using FactoryDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    class MainMethod
    {
        public IScreen ScreenFactory(ScreenType screenType)
        {
            if (screenType == ScreenType.Laptop)
            {
                return new LaptopScreen();
            }
            else if (screenType == ScreenType.Tablet)
            {
                return new TabletScreen();
            }
            else
            {
                return new MobilePhoneScreen();
            }
        }
    }
}
