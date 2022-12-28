using MediatorDesignPattern.Concerete;

namespace MediatorDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            User user1 = new User("Smith");
            User user2 = new User("Justin");

            mediator.Login(user1);
            mediator.Login(user2);

            user1.sendNotification(user2.Name, "Hello");
            user2.sendNotification(user1.Name, "Hey! How are you?");
        }
    }
}
