using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //var customers = Before.Repository.Customers;
            //foreach (var customer in customers)
            //{
            //    var notificationService = new Before.NotificationService(customer);
            //    notificationService.Notify();
            //}

            var customers = After.Repository.Customers;
            foreach (var customer in customers)
            {
                var messageService = new List<After.IMessageService>
                {
                    new After.SMSService { MobileNo = customer.MobileNo},
                    new After.EmailService { EmailAddress = customer.EmailAddress}
                };

                var notificationService = new After.NotificationService(messageService);
                notificationService.Notify();

            }

            Console.ReadKey();
        }
    }
}
