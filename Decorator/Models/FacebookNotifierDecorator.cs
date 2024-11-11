using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Models
{
    public class FacebookNotifierDecorator : NotifierDecorator
    {
        private readonly string _facebookUsername;

        public FacebookNotifierDecorator(INotifier notifier, string facebookUsername) : base(notifier)
        {
            _facebookUsername = facebookUsername;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправка сообщения Facebook на { _facebookUsername}: {message}");
        }
    }
}
