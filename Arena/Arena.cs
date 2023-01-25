using System;
using System.Linq;

namespace Arena
{
    internal class Boj
    {
        Bojovnik bojovnik1;
        Bojovnik bojovnik2;
        Kostka kostka;

        public Boj(Bojovnik bojovnik1, Bojovnik bojovnik2, Kostka kostka)
        {
            this.bojovnik1 = bojovnik1;
            this.bojovnik2 = bojovnik2;
            this.kostka = kostka;
        }
        private void VypisInfo()
        {
            Console.Clear();
            Console.WriteLine("-------------- Aréna -------------- \n");
            Console.WriteLine("Zdraví bojovníků: \n");
            Console.WriteLine("{0} {1}", bojovnik1, bojovnik1.ZivotGraficky());
            Console.WriteLine("{0} {1}", bojovnik2, bojovnik2.ZivotGraficky());
        }
        private void VypisZpravy(string zprava)
        {
            Console.WriteLine(zprava);
            Thread.Sleep(1000);
        }
        public void Zapas()
        {
            Bojovnik b1 = bojovnik1;
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Dnes se utkají {0} s {1}! \n", bojovnik1, bojovnik2);
            Console.WriteLine("Zápas může začít...");

            while (bojovnik1.Nazivu() && bojovnik2.Nazivu())
            {
                bojovnik1.Utok(bojovnik2);
                VypisInfo();
                VypisZpravy(bojovnik1.VypsatZpravu());
                VypisZpravy(bojovnik2.VypsatZpravu());
                bojovnik2.Utok(bojovnik1);
                VypisInfo();
                VypisZpravy(bojovnik1.VypsatZpravu());
                VypisZpravy(bojovnik2.VypsatZpravu());
                Console.ReadKey();
            }

        }
    }
}
