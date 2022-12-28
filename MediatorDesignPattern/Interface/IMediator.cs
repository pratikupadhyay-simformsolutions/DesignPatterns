using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Interface
{
    public interface IMediator
    {
        public void Login(User user);
        public void SendNotification(string sender, string receiver, string message);
    }
}
