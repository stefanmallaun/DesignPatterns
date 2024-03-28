using Observer.Models;

namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // StockSubject erzeugen
            StockSubject tesla = new StockSubject("Tesla", 29.09m);
            
            // dem Observer das Subject bekanntgeben
            Observer1 overserver1 = new Observer1(tesla);

            Console.WriteLine(tesla);
            
            // den Observer beim Subject registrieren
            tesla.Register(overserver1);

            Thread.Sleep(1000);

            // Wert der Aktien verändern
            tesla.Value = 31.12m;

            Observer2 observer2 = new Observer2(tesla);

            Console.WriteLine("\n2ten Observer registrieren\n");
            Thread.Sleep(3000);
            tesla.Register(observer2);

            Console.WriteLine("\nTesla-Aktie ändern \n");
            tesla.Value += 32.20m;
            //  nun sollten beide Observer ihre Meldung ausgeben


            // zusätzliche Anpassungen
            // 1. die Observer sollten nur informiert werden, wenn der Aktienwert einen
            //      bestimmten Schwellenwert (dieser Wert soll an den ctor übergeben werden)
            //      überschritten wird

            // 2. die Observer sollten die Daten nur dann anzeigen, wenn der Aktienwert
            //      einen bestimmten Wert überschreitet (soll ebenfalls dem ctor übergeben werden)
        }
    }
}