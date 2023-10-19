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
    }
}
