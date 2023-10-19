using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public abstract class Szamla :BankiSzolgaltatas
    {
        private int akktualisegyenleg;

        protected Szamla(int akktualisegyenleg,Tulajdonos tulajdonos) : base(tulajdonos) 
        {
            this.akktualisegyenleg = akktualisegyenleg;
        }

        public int Akktualisegyenleg { get => akktualisegyenleg;}

        public void Befizet(int osszeg)
        {
            akktualisegyenleg = akktualisegyenleg+ osszeg;
        }
        public bool Kivesz(int osszeg)
        {
            if (akktualisegyenleg - osszeg > 0)
            {
                akktualisegyenleg = akktualisegyenleg -osszeg;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
