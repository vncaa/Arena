using System;
using System.Linq;

namespace Arena
{
    internal class Kostka
    {
        private int pocetStran;
        private Random rnd = new Random();

        public Kostka()
        {
            this.pocetStran = 6;
        }
        public Kostka(int pocetStran)
        {
            this.pocetStran = pocetStran;
        }
        public int HodKostkou()
        {
            return rnd.Next(1, pocetStran + 1);
        }
        public int PocetStran()
        {
            return pocetStran;
        }
    }
}
