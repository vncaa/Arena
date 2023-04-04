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
            //pocatecni informace
            Console.Clear();
            Console.WriteLine("-------------- Aréna -------------- \n");
            Console.WriteLine("Zdraví bojovníků: \n");
            Console.WriteLine($"{bojovnik1} {bojovnik1.ZivotGraficky()} (Životy: {bojovnik1.maxZivot} | Útok: {bojovnik1.utok} | Obrana: {bojovnik1.obrana} )");
            Console.WriteLine($"{bojovnik2} {bojovnik2.ZivotGraficky()} (Životy: {bojovnik2.maxZivot} | Útok: {bojovnik2.utok} | Obrana: {bojovnik2.obrana} )");
        }
        private void VypisZpravy(string zprava)
        {
            //vypsani zpravy o aktualnim stavu utoku a obrany
            Console.WriteLine(zprava);
            Thread.Sleep(1000);
        }
        public void Zapas()
        {
            //poradi bojovniku na zacatku
            Bojovnik b1 = bojovnik1;
            Bojovnik b2 = bojovnik2;
            Console.WriteLine("Vítejte v aréně!");
            Console.WriteLine("Dnes se utkají {0} s {1}! \n", bojovnik1, bojovnik2);

            //zacina druhy bojovnik, pokud padlo cislo mensi jak polovina stran kostky
            bool zacinaBojovnik2 = (kostka.HodKostkou() <= kostka.PocetStran() / 2);
            if (zacinaBojovnik2)
            {
                b1 = bojovnik2;
                b2 = bojovnik1;
            }
            Console.WriteLine("Zápas může začít...");

            //boj
            while (bojovnik1.Nazivu() && bojovnik2.Nazivu())
            {
                b1.Utok(b2);
                VypisInfo();
                VypisZpravy(b1.VypsatZpravu());
                VypisZpravy(b2.VypsatZpravu());
                Console.ReadKey();
                if (b2.Nazivu())
                {
                    b2.Utok(b1);
                    VypisInfo();
                    VypisZpravy(b2.VypsatZpravu());
                    VypisZpravy(b1.VypsatZpravu());
                }
                Console.ReadKey();
            }

        }
    }
}
