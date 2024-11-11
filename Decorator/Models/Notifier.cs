using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Models
{
    public class Notifier : INotifier
    {
        private readonly string _emailAddress;

        public Notifier(string emailAddress)
        {
            _emailAddress = emailAddress;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Отправка электронной почты на {_emailAddress}: {message}");
        }
    }
}
