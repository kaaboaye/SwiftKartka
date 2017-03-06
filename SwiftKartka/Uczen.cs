using System;
using System.Collections.Generic;

namespace SwiftKartka
{
    public class Uczen
    {
        private string imie;
        private string nazwisko;
        private int rokUrodzenia;
        private Zameldowanie adresZamieszkania;
        private List<byte> oceny;

        public string Imie
        {
            get => imie;
        }

        public string Nazwisko
        {
            get => nazwisko;
        }

        public string DataUrodzenia
        {
            get
            {
                return $"??.??.{rokUrodzenia}";
            }
        }

        public Zameldowanie AdresZamieszkania
        {
            get => adresZamieszkania;
        }

        public List<byte> Oceny
        {
            get => oceny;
            set { oceny = value; }
        }

        public Uczen(
            string Imie,
            string Nazwisko,
            string DataUrodzenia,
            Zameldowanie AdresZamieszkania
            )
        {
            this.imie = Imie;
            this.nazwisko = Nazwisko;
            this.adresZamieszkania = AdresZamieszkania;

            byte n = 0;
            string rokUrodzenia = String.Empty;

            foreach (char Char in DataUrodzenia)
            {
                n++;

                switch (n)
                {
                    case 1:
                    case 2:
                        // Dzień urodznia
                        break;
                    case 4:
                    case 5:
                        // Miesiąc urodzenia
                        break;
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        rokUrodzenia += Char;
                        break;
                }
            }
            
            this.rokUrodzenia = int.Parse(rokUrodzenia);
            this.oceny = new List<byte>();
        }

        public int Wiek(int Rok)
        {
            return (Rok - rokUrodzenia) * 12;
        }
        
        public void DodajOcene(byte Ocena)
        {
            Oceny.Add(Ocena);
        }

        public float SredniaOcen()
        {
            float suma = 0f;
            float iloscOcen = Oceny.Count;

            foreach (byte ocena in Oceny)
            {
                suma += ocena;
            }

            return suma / iloscOcen;
        }

        public void PrintInfo()
        {
            void t(byte tab, string s)
            {
                for (byte n = 0; n < tab; n++)
                {
                    s = "  " + s;
                }

                Console.WriteLine(s);
            }

            void l(byte tab, string s)
            {
                for (byte n = 0; n < tab; n++)
                {
                    s = "  " + s;
                }

                Console.Write(s);
            }

            t(1, "");
            t(1, $"Uczen: {Imie} {Nazwisko}");
            t(2, @"Adres zamieszkania:");
            t(3, $"{AdresZamieszkania.KodPocztowy}");
            t(3, $"{AdresZamieszkania.Ulica} {AdresZamieszkania.NumerDomu}");
            t(2, $"Srednia ocen: {SredniaOcen()}");
            l(2, @"Oceny: ");

            string oceny = String.Empty;
            foreach (byte ocena in Oceny)
            {
                oceny += ocena.ToString() + ", ";
            }
            t(0, $"{oceny}");
        }
    }
}
