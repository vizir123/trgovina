using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Zaposlenik : Osoba

    {
        protected decimal placa;

        public Zaposlenik(string ime, string prezime, decimal placa) : base(ime, prezime)
        {
            this.placa = placa;
        }

        //koristimo decimal jer radimo s novcima
        public decimal VratiPlacu()
        {
            return placa;
        }

        public override string Prikazi()
        {
            return String.Format("Zaposlenik: {0}, {1}\nPlaca: {2}", ime, prezime, placa);
        }
    }
}
