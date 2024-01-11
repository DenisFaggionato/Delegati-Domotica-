using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{

    public abstract class Sensore
    {
        public delegate void InviaNotifica(float valore, string descrizione, string unità);
        public event InviaNotifica EventoNotifica;
        EventoNotifica += AVocale.Parla;
        EventoNotifica += Smartphone.InvioEmail;
        EventoNotifica += Smartwatch.MostraValore;


        public float valore = 0;
        public string descrizione;
        public string unità;

        public Sensore(float valore, string descrizione, string unità)
        {
            this.valore = valore;
            this.descrizione = descrizione;
            this.unità = unità;
        }

        public virtual void LeggiDato(float valore)
        {
            

        }
        public void InvioNotifiche(float valore, string descrizione, string unità)
        {
            EventoNotifica(valore,descrizione,unità);
        }
        public void UtilizzoMotore(bool a)
        {
            Motore.Motore(null, a);
        }
    }
}
