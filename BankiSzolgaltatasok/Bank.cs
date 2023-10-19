using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public class Bank
    {
        List<Szamla> szamlalista = new List<Szamla>();
        private long osszHitelkeret;

        public long OsszHitelkeret { get => osszHitelkeret;}

        public Szamla SzamlaNyitas(Tulajdonos tulajdonos, int hitelkeret)
        {
            if (hitelkeret==0)
            {
                MegtakaritasiSzamla m = new MegtakaritasiSzamla(tulajdonos);
                return m;
            }
            else if(hitelkeret<0)
            {
                throw new Exception();
            }
            else
            {
                HitelSzamla h = new HitelSzamla(tulajdonos, hitelkeret);
                return h;
                this.osszHitelkeret = this.osszHitelkeret + hitelkeret;
            }
        }
        public int GetOsszEgyenleg(Tulajdonos tulajdonos)
        {
            int seged = 0;
            foreach(var item in szamlalista)
            {
                if(item.Tulajdonos == tulajdonos)
                {
                    seged = seged + item.AktualisEgyenleg;
                }
            }
            return seged;
        }
        public Szamla GetLegnagyobbEgyenleguSzamla(Tulajdonos tulajdonos)
        {
            Szamla seged = null;
            int osszeg=0;
            foreach (var item in szamlalista)
            {
                if (item.Tulajdonos == tulajdonos && item.AktualisEgyenleg>osszeg)
                {
                    seged = item;
                    osszeg = item.AktualisEgyenleg;
                }
            }
            return seged;
        }
    }
}
