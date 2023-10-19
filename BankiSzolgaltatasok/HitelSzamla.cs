using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class HitelSzamla : Szamla
    {
        private int hitelKeret;

        public HitelSzamla(int hitelKeret, Tulajdonos tulajdonos): base(tulajdonos)
        {
            this.hitelKeret = hitelKeret;
        }

        public int HitelKeret { get => hitelKeret;}
        public override bool Kivesz(int osszeg)
        {
            if (AktualisEgyenleg - osszeg > 0) 
            {
                return true;
            }
            else if((AktualisEgyenleg-osszeg)*-1>hitelKeret)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
