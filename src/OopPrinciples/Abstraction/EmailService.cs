using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//dont have to worry about the internal details of the class 

namespace OOPs.src.OopPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenicate();
            Console.WriteLine("sending email..");
            Disconnet();
        }
        private void Connect()
        {
            Console.WriteLine("connecting to email server..");
        }
        private void Authenicate()
        {
            Console.WriteLine("autheticating..");
        }
        private void Disconnet()
        {
            Console.WriteLine("disconnecting..");
        }
    }
}