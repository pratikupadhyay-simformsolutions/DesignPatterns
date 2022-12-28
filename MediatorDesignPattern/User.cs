using MediatorDesignPattern.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class User
    {
        public string Name { get; set; }
        public Mediator concreteMediator { set; get; }
        public User(string name)
        {
            this.Name = name;
        }
        public void sendNotification(string receiver, string messsage)
        {
            concreteMediator.SendNotification(Name, receiver, messsage);
        }
        public virtual void ReceiverNotification(string sender, string messsage)
        {
            Console.WriteLine("{0} to {1}: '{2}'", sender, Name, messsage);
        }
    }
}
