//badCoupling example 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs.src.OopPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {

        public void SendNotification(string message)
        {
            System.Console.WriteLine($"sending email {message}");
        }
    }
}