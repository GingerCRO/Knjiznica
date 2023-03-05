using System;

namespace Knjiznica
{
    public class Knjiga : IComparable<Knjiga>
    {

        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Naslov { get; set; }
        public int GodinaIzdanja { get; set; }
        public int BrojPrimjeraka { get; set; }

        public int CompareTo(Knjiga other)
        {
            
            int rez = Autor.CompareTo(other.Autor);

            if (rez == 0)
            {
                rez = Naslov.CompareTo(other.Naslov);
            }

            return rez;

        }

        public override string ToString()
        {

            return Autor + ": " + Naslov;
        
        }

    }
}
