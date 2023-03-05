using System;

namespace Knjiznica
{
    public class Posudba : IComparable<Posudba>
    {

        public Ucenik Ucenik { get; set; }
        public Knjiga Knjiga { get; set; }
        public DateTime DatumPosudbe { get; set; }
        public int BrojDana { get; set; }

        public DateTime DatumVracanja
        {
            get
            {
                return DatumPosudbe.AddDays(BrojDana);
            }
        }

        public override string ToString()
        {

            return DatumPosudbe.ToShortDateString() + " - " + DatumVracanja.ToShortDateString();
        
        }

        public int CompareTo(Posudba other)
        {

            return DatumVracanja.CompareTo(other.DatumVracanja);

        }

    }
}
