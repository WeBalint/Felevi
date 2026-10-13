namespace jatekok
{
    internal class Program
    {
        class Jatek
        {
            public string Nev;
            public string Fejleszto;
            public int MegjelenesiEv;
            public string Mufaj;
            public double Ertekeles;
            public int Eladas;

            public Jatek(string nev, string fejleszto, int megjelenesiEv,string mufaj, double ertekeles, int eladas)
            {
                Nev = nev;
                Fejleszto = fejleszto;
                MegjelenesiEv = megjelenesiEv;
                Mufaj = mufaj;
                Ertekeles = ertekeles;
                Eladas = eladas;
            }
        }
        static void Main(string[] args)
        {
            List<Jatek> jatekok = new List<Jatek>();
            StreamReader beFajl = new StreamReader("jatekok.txt");

            string sor;

            while (!beFajl.EndOfStream)
            {
                sor = beFajl.ReadLine();
                string[] adatok = sor.Split(';');

                string nev = adatok[0];
                string fejleszto = adatok[1];
                int megjelenesiEv = int.Parse(adatok[2]);
                string mufaj = adatok[3];
                double ertekeles = double.Parse(adatok[4]);
                int eladas = int.Parse(adatok[5]);

                Jatek jatek = new Jatek(nev, fejleszto, megjelenesiEv, mufaj, ertekeles, eladas);
                jatekok.Add(jatek);
            }

            beFajl.Close();

            Console.WriteLine("A játékok beolvasása sikeres!");
            Console.WriteLine("Beolvasott játékok száma: " + jatekok.Count);
        }
    }
}
