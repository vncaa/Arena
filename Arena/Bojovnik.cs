using System;
using System.Linq;

namespace Arena
{
    internal class Bojovnik
    {
        private string zprava;
        protected string jmeno;
        private int zivot;
        public int maxZivot;
        public int utok;
        public int obrana;
        protected Kostka kostka;

        public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
        {
            this.jmeno = jmeno;
            this.zivot = zivot;
            this.maxZivot = zivot;
            this.utok = utok;
            this.obrana = obrana;
            this.kostka = kostka;
        }
        protected void UlozitZpravu(string zprava)
        {
            this.zprava = zprava;
        }
        public string VypsatZpravu()
        {
            return zprava;
        }
        public void Obrana(int uder)
        {
            int zraneni = uder - (obrana + kostka.HodKostkou());
            if (zraneni > 0)
            {
                zivot -= zraneni;
                zprava = $"{jmeno} utrpěl zranění za {zraneni} hp";
                if (zivot <= 0)
                {
                    zivot = 0;
                    zprava += " a zemřel";
                }
            }
            else
                zprava = $"{jmeno} odrazil útok";
            UlozitZpravu(zprava);
        }
        public virtual void Utok(Bojovnik souper)
        {
            int uder = utok + kostka.HodKostkou();
            UlozitZpravu($"{jmeno} útočí úderem za {uder} hp");
            souper.Obrana(uder);
        }
        public bool Nazivu()
        {
            return (zivot > 0);
        }
        public override string ToString()
        {
            return jmeno;
        }
        public string ZivotGraficky()
        {
            string s = "[";
            int celkem = 20;
            double pocet = Math.Round(((double)zivot / maxZivot) * celkem);
            if ((pocet == 0) && (Nazivu()))
                pocet = 1;
            for (int i = 0; i < pocet; i++)
                s += "#";
            s = s.PadRight(celkem + 1);
            s += "]";
            return s;
        }
    }

}
