using Observer2.Models;


namespace Observer2 {
    internal class Program {
        static void Main(string[] args) {

            //  In einem Fahrzeug soll bei Überschreitung einer bestimmten Drehzahl ein Soundalarm ausgelöst
            //  und im Display eine entsprechende Meldung in rot angezeigt werden. Überlege dir für diese Aufgabenstellung 
            //  ein sinnvolles Pattern und implementiere es. Überprüfe deine Lösung im Hauptprogramm. 

          
                // StockSubject erzeugen
                CarSubject anzeige = new CarSubject("Anzeige", 500m);

            // dem Observer das Subject bekanntgeben
            Observer observer1 = new Observer(anzeige);

                Console.WriteLine(observer1);

                // den Observer beim Subject registrieren
                anzeige.Register(observer1);

                Thread.Sleep(1000);

                // Wert der Aktien verändern
                anzeige.Value = 50.12m;


            Thread.Sleep(1000);
                anzeige.Value += 160.20m;

            }
        }
    }