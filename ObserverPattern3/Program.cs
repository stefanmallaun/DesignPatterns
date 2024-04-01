using ObserverPattern3.Models;

namespace ObserverPattern3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           CarSubject subject = new CarSubject("Fiat", 500);

            Observer observer = new Observer(subject);

            Console.WriteLine(subject) ;

            Thread.Sleep(1000);

            subject.Register(observer);

            subject.Value = 10;

            Thread.Sleep(1000);

            subject.Value = 1000;

        }
    }
}

