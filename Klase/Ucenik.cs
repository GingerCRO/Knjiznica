using System;

namespace Knjiznica
{
    public class Ucenik : IComparable<Ucenik>
    {

        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public int Razred { get; set; }

        public int CompareTo(Ucenik other)
        {
            
            int rez = Prezime.CompareTo(other.Ime);

            if (rez == 0)
            {
                rez = Ime.CompareTo(other.Ime);
            }

            return rez;

        }

        public override string ToString()
        {
            
            return Prezime + ", " + Ime + ": " + Razred;

        }

    }
}
