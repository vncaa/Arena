using Arena;

Kostka kostka = new Kostka(6);
Bojovnik pepa = new Bojovnik("Pepa", 20, 5, 3, kostka);
Bojovnik franta = new Mag("Franta", 20, 5, 3, kostka, 5, 8);
Boj arena = new Boj(pepa, franta, kostka);

arena.Zapas();