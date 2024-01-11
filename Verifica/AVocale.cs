using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    public class AVocale
    {
        public float valore;
        public string descrizione;
        public string unità;
        public void Parla(float valore, string descrizione, string unità)
        {
            Console.WriteLine($"Oggi ci sono {valore}{unità},{descrizione}");
        }
    }
}
