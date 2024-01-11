using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{

    public class Smartphone
    {
        public float valore;
        public string descrizione;
        public string unità;
        public void InvioEmail(float valore, string descrizione, string unità)
        {
            Console.WriteLine($"Buongiorno, le scrivo per dirle che oggi ci sono: {valore}{unità}, {descrizione}");
        }

    }
}
