using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models.API
{
    internal class VisaAPI
    {
        // von VISA zur Verfügung gestellt
        //warum static? ... muss keine Instanz erzeugen, nur angenehmer zu verwenden
        public static bool PayWithVisa(decimal value)
        {
            return true;
            // das würde das ausführen was paypal normal macht
        }
    }
}
