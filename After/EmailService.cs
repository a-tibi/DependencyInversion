using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.After
{
    internal class EmailService: IMessageService
    {
        public string EmailAddress { get; set; }

        public void Send()
        {
            Console.WriteLine($"E-mail is sent to {EmailAddress}");
        }
    }
}
