using System;

namespace PubSubDesignPattern.Subscriber
{
    public class DaySubscriber : ISubscriber
    {
        public void Display(DateTime dateTime)
        {
            Console.WriteLine("Day today: " + dateTime.DayOfWeek);
        }
    }
}
