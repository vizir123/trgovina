using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Kupac : Osoba

    {
        protected static List<string> artikli = new List<string>();

        public Kupac(string ime, string prezime) : base(ime, prezime)
        {

        }

        public void DodajArtikle(string nazivArtikla)
        {
            artikli.Add(nazivArtikla);
        }

        public override string Prikazi()
        {
            Console.WriteLine("KUPAC: {0}, {1}", ime, prezime);
            foreach (string artikl in artikli)
            {
                Console.WriteLine(artikl);
            }

            return String.Format("\nBroj Artikala: " + artikli.Count());
        }
    }
}
