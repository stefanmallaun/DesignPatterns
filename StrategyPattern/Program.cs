using Strategy_Pattern.Models;

namespace StrategyPattern {
    internal class Program {
        static void Main(string[] args) {
            Customer customer = new Customer() {
                Name = "TJ_BB"
            };
            Article a1 = new Article() {
                Price = 190.90m
            };

            Article a2 = new Article() {
                Price = 120m
            };

            Article a3 = new Article() {
                Price = 190.90m
            };

            BasketItem bi1 = new() {
                Article = a1,
                Amount = 1,
            };

            BasketItem bi2 = new() {
                Article = a3,
                Amount = 1,
            };

            Basket basket = new() {
                Customer = customer,
            };
            basket.Basketitems.Add(bi1);
            basket.Basketitems.Add(bi2);
            // wenn STRG gedrückt halten, dann auf die methoden, dann werden wir da hingeführt
            // Warenkorb inklusive Artikel und Customer existiert nun 


            // jetzt muss noch die Bezahlmethode ausgewählt werden
            Console.WriteLine("Bittte Bezahlmethode auswählen(): [p... PayPal, v... Visa]:");
            char choice = Convert.ToChar(Console.ReadLine());
            //liest Zeichenketten, muss man konvertieren

            //Strategy Pattern
            switch (choice) {
                case 'p':
                    basket.PaymentMethod = new PayPalStrategy();
                    break;
                case 'v':
                    basket.PaymentMethod = new VisaStrategy();
                    break;
                default:
                    Console.WriteLine("bitte Zahlungsmethode auswählen");
                    break;
            }
            Console.WriteLine("Kunde: " + basket.Customer.Name);
            // Betrag bezahlen 
            if (basket.PayBasket()) {

                Console.WriteLine("Bezahlung erfolgreich!");
            }
            else {
                Console.WriteLine("Bezahlung konnte nicht durchgeführt werden");
            }
        }
    }
}