using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Knjiznica
{
    public class PodatkovniKontekst
    {

        private List<Ucenik> ucenici;
        private List<Knjiga> knjige;
        private List<Posudba> posudbe;

        public List<Ucenik> Ucenici
        {
            get { return ucenici; }
        }

        public List<Knjiga> Knjige
        {
            get { return knjige; }
        }

        public List<Posudba> Posudbe
        {
            get { return posudbe; }
        }

        public PodatkovniKontekst()
        {

            ucenici = UcitajUcenike();
            knjige = UcitajKnjige();
            posudbe = UcitajPosudbe();

        }

        private string datUcenici = @"D:\Skola_4e\NOP\Knjiznica\datUcenici.txt";
        private string datKnjige = @"D:\Skola_4e\NOP\Knjiznica\datKnjige.txt";
        private string datPosudbe = @"D:\Skola_4e\NOP\Knjiznica\datPosudbe.txt";

        private List<Ucenik> UcitajUcenike()
        {

            List<Ucenik> ucenici = new List<Ucenik>();

            if (File.Exists(datUcenici))
            {
                using (StreamReader sr = new StreamReader(datUcenici))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');

                        Ucenik u = new Ucenik();
                        u.OIB = polja[0];
                        u.Ime = polja[1];
                        u.Prezime = polja[2];
                        u.Adresa = polja[3];
                        u.Telefon = polja[4];
                        u.Razred = int.Parse(polja[5]);

                        ucenici.Add(u);
                    }
                }
            }

            return ucenici;

        }

        private List<Knjiga> UcitajKnjige()
        {

            List<Knjiga> knjige = new List<Knjiga>();

            if (File.Exists(datKnjige))
            {
                using (StreamReader sr = new StreamReader(datKnjige))
                {
                    while (!sr.EndOfStream)
                    {
                        string linija = sr.ReadLine();
                        string[] polja = linija.Split('|');

                        Knjiga k = new Knjiga();
                        k.ISBN = polja[0];
                        k.Autor = polja[1];
                        k.Naslov = polja[2];
                        k.GodinaIzdanja = int.Parse(polja[3]);
                        k.BrojPrimjeraka = int.Parse(polja[4]);

                        knjige.Add(k);
                    }
                }
            }

            return knjige;

        }

        public List<Posudba> UcitajPosudbe()
        {

            return posudbe;

        }

        public void SpremiUcenike()
        {

            using (StreamWriter sw = new StreamWriter(datUcenici))
            {
                foreach(Ucenik u in ucenici)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}", u.OIB, u.Ime, u.Prezime, u.Adresa, u.Telefon, u.Razred);
                }
            }

        }

        public void SpremiKnjige()
        {

            using (StreamWriter sw = new StreamWriter(datKnjige))
            {
                foreach (Knjiga k in knjige)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}|{4}", k.ISBN, k.Autor, k.Naslov, k.GodinaIzdanja, k.BrojPrimjeraka);
                }
            }

        }

        public void SpremiPosudbe()
        {

            using (StreamWriter sw = new StreamWriter(datPosudbe))
            {
                foreach (Posudba p in posudbe)
                {

                }
            }

        }

        public void BrisiUcenika(Ucenik u)
        {
            ucenici.Remove(u);
        }

    }
}
