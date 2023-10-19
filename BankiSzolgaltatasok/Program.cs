using System.Runtime.Intrinsics.X86;

namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tulajdonos t1 = new Tulajdonos("Tomik Dávid");
            Bank b = new Bank();
            b.SzamlaNyitas(t1, 1000);
            b.SzamlaNyitas(t1, 0);
            Console.WriteLine(b.GetOsszEgyenleg(t1));
            Console.ReadKey();
        }
    }
}