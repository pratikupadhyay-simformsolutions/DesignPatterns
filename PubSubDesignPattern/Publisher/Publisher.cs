using PubSubDesignPattern.Publisher;
using System;
using System.Threading;

namespace PubSubDesignPattern.Publisher
{
    public delegate void DateTimeDelegate(DateTime dateTime);

    public class Publisher : IPublisher
    {
        private event DateTimeDelegate _dateTimeEvent;

        /// <summary>
        /// Subscribe to event
        /// </summary>
        /// <param name="dateTimeHandler"></param>
        public void Subscribe(DateTimeDelegate dateTimeHandler)
        {
            _dateTimeEvent += dateTimeHandler;
        }

        /// <summary>
        /// Start publishing date time
        /// </summary>
        public void Start()
        {
            while (true)
            {
                _dateTimeEvent?.Invoke(DateTime.Now);

                Thread.Sleep(1000);
            }
        }
    }
}
