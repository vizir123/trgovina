using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        private static List<Osoba> osobe = new List<Osoba>();
        static void Main(string[] args)
        {
            int broj = 0;
            decimal ukupno = 0;

            Osoba o = new Osoba("Nikola", "Petrić");
            osobe.Add(o);

            Zaposlenik pero = new Zaposlenik("Pero", "Nikić", 5040.32m);
            broj++;
            ukupno += pero.VratiPlacu();
            osobe.Add(pero);

            Zaposlenik marko = new Zaposlenik("Marko", "Matić", 3000.50m);
            broj++;
            ukupno += marko.VratiPlacu();
            osobe.Add(marko);

            Kupac david = new Kupac("David", "Barić");
            david.DodajArtikle("Mlijeko");
            david.DodajArtikle("Brasno");
            david.DodajArtikle("Ulje");
            osobe.Add(david);

            Console.WriteLine("LISTA OSOBA(" + osobe.Count() + "): ");
            foreach (Osoba os in osobe)
            {
                Console.WriteLine(os.Prikazi());
                Console.WriteLine("------");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Prosjek place zaposlenika: " + ukupno / broj);

        }
    }
}