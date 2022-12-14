using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    public class Posudba
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

    }
}
