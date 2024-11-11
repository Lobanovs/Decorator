using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Models
{
    public class SMSNotifierDecorator : NotifierDecorator
    {
        private readonly string _phoneNumber;

        public SMSNotifierDecorator(INotifier notifier, string phoneNumber) : base(notifier)
        {
            _phoneNumber = phoneNumber;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправка SMS на {_phoneNumber}: {message}");
        }
    }
}
