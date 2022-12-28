using PubSubDesignPattern.Publisher;

namespace PubSubDesignPattern.Publisher


{
    public interface IPublisher
    {
        void Subscribe(DateTimeDelegate dateTimeHandler);
    }
}
