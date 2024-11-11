using Decorator.Interfaces;
using Decorator.Models;

class Program
{
    static void Main()
    {
        
        INotifier notifier = new Notifier("user@gmail.com");

       
        notifier = new SMSNotifierDecorator(notifier, "+782312921312");

       
        notifier = new FacebookNotifierDecorator(notifier, "DonaldTramp");

       
        notifier.Send("Система рухнула!");
    }
}