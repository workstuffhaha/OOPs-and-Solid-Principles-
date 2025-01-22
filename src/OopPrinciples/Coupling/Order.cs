using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// in this explain we have de coupled the order class from the notification implementation using interfaces
namespace OOPs.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;
        
        //order class constructor accepts any class that implements INotificationService 
        public Order(INotificationService notificationService)
        {
            this.notificationService=notificationService;
        }
        public void PlaceOrder()
        {
            //place order logic

            notificationService.SendNotification("order placed succesfully");
        }
    }
}