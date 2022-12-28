using FactoryDesignPattern.Abstract;
using FactoryDesignPattern.Enum;
using FactoryDesignPattern.Factory;

namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMethod mainMethod = new MainMethod();
            IScreen laptop = mainMethod.ScreenFactory(ScreenType.Laptop);
            IScreen tablet = mainMethod.ScreenFactory(ScreenType.Tablet);
            IScreen mobilePhone = mainMethod.ScreenFactory(ScreenType.MobilePhone);
            laptop.Draw();
            tablet.Draw();
            mobilePhone.Draw();
        }
    }
}