using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPs.src.OopPrinciples.Coupling
{
    //making an interface to reduce the coupling
    // allows flexibility to use different notification methods without changing the Order class code.
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}