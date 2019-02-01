using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Osoba
    {
  
        protected string ime;
        protected string prezime;

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        //stvaramo dinamicko povezivanje
        public virtual string Prikazi()
        {
            return String.Format("Ime i Prezime: {0}, {1}", ime, prezime);
        }
    }
}
