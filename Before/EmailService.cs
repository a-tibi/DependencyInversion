using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Before
{
    internal class EmailService
    {
        public string EmailAddress { get; set; }

        public void Send()
        {
            Console.WriteLine($"E-mail is sent to {EmailAddress}");
        }
    }
}
