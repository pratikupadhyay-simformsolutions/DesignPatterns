using System;

namespace PubSubDesignPattern.Subscriber
{
    public class DateTimeSubscriber : ISubscriber
    {
        public void Display(DateTime dateTime)
        {
            Console.WriteLine("Date time: " + dateTime);
        }
    }
}
