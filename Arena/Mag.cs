using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Mag : Bojovnik
    {
        private int mana;
        private int maxMana;
        private int magickyUtok;

        public Mag(string jmeno, int zivot, int utok, int obrana, Kostka kostka, int mana, int magickyUtok) : base(jmeno, zivot, utok, obrana, kostka)
        {
            this.mana = mana;
            this.maxMana = mana;
            this.magickyUtok = magickyUtok;
        }
        public override void Utok(Bojovnik souper)
        {
            // Mana není naplněna
            if (mana < maxMana)
            {
                mana += 10;
                if (mana > maxMana)
                    mana = maxMana;
                base.Utok(souper);
            }
            else // Magický útok
            {
                int uder = magickyUtok + kostka.HodKostkou();
                UlozitZpravu(String.Format("{0} použil magii za {1} hp", jmeno, uder));
                souper.Obrana(uder);
                mana = 0;
            }
        }
    }
}
