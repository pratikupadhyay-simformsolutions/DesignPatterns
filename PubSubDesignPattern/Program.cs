

namespace PubSubDesignPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Publisher.Publisher publisher = new();

            Subscriber.DateTimeSubscriber dateSub = new();
            Subscriber.DaySubscriber daySub = new();

            publisher.Subscribe(dateSub.Display);
            publisher.Subscribe(daySub.Display);

            publisher.Start();
        }
    }
}
