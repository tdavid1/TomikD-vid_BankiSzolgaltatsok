using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class Szamla :BankiSzolgaltatas
    {
        protected int aktualisEgyenleg;

        protected Szamla(Tulajdonos tulajdonos) : base(tulajdonos) 
        {
        }

        public int AktualisEgyenleg { get => aktualisEgyenleg;}

        public void Befizet(int osszeg)
        {
            aktualisEgyenleg = aktualisEgyenleg + osszeg;
        }
        public abstract bool Kivesz(int osszeg);
        public Kartya UjKartya(string kartyasszam)
        {
            Kartya k = new Kartya(Tulajdonos,this, kartyasszam);
            return k;
        }
    }
}
