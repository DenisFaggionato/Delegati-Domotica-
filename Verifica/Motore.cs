using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    public class Motore
    {
        public bool TemperaturaAlta;
        public bool LuceAlta;


        public Motore(bool TemperaturaAlta, bool LuceAlta) 
        {
            this.LuceAlta = LuceAlta;
            this.TemperaturaAlta = TemperaturaAlta;
        }

        public void AssocioValore(bool? TA, bool? LA)
        {
            if(TA = null) 
            { 
                LuceAlta = LA;
                Tapparelle(TA, LA);

            }
            if (LA = null)
            {
                TemperaturaAlta = TA;
                Tapparelle(TA, LA);

            }
            else
                Tapparelle(TA, LA);

        }
        public void Tapparelle(bool TemperaturaAlta, bool LuceAlta)
        {
            if(!LuceAlta) 
                 Console.WriteLine("Sto alzando le tapparelle");

            if (LuceAlta && TemperaturaAlta)
                Console.WriteLine("Sto chiudento le tapparelle");

        }
    }
}
