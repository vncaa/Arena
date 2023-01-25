using Arena;

Kostka kostka = new Kostka(6);
Bojovnik pepa = new Bojovnik("Pepa", 20, 5, 3, kostka);
Bojovnik franta = new Bojovnik("Franta", 15, 8, 5, kostka);
Boj arena = new Boj(pepa, franta, kostka);

arena.Zapas();