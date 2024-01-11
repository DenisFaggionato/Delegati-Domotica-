using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{

    public class Smartwatch
    {
        public float valore;
        public string descrizione;
        public string unità;

        public void MostraValore(float valore, string descrizione, string unità)
        {
            Console.WriteLine($"{valore}{unità}");
        }
    }
}
