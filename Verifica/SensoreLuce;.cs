using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    public  class SensoreTemp : Sensore
    {
        public float valore;
        public SensoreTemp(float valore, string descrizione, string unità) : base(valore, descrizione, unità)
        {

        }
        public override void LeggiDato(float valore)
        {
            if (valore > 30)
            {
                base.valore = valore;
                base.descrizione = "CALDO";
                base.unità = "°C";
                Motore.AssocioValore(true, null);
            }
            else if (valore > 10)
            {
                base.valore = valore;
                base.descrizione = "TEMPERATO";
                base.unità = "°C";
            }
            else
            {
                base.valore = valore;
                base.descrizione = "Freddo";
                base.unità = "°C";
            }
            base.InvioNotifiche(valore,descrizione,unità);
        }
    }
}
