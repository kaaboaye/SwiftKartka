using System;
using System.Collections.Generic;
using System.Text;

namespace SwiftKartka
{
    public class Klasa
    {
        private string nazwaKlasy;
        private string nazwiskoNauczyciela;
        private int rocznik;
        private List<Uczen> uczniowie;

        public string NazwaKlasy
        {
            get => nazwaKlasy;
        }

        public string NazwiskoNauczyciela
        {
            get => nazwiskoNauczyciela;
        }

        public int Rocznik
        {
            get => rocznik;
        }

        public List<Uczen> Uczniowie
        {
            get => uczniowie;
        }

        public Klasa(
            string NazwaKlasy,
            string NazwiskoNauczyciela,
            int Rocznik,
            List<Uczen> Uczniowie
            )
        {
            this.nazwaKlasy = NazwaKlasy;
            this.nazwiskoNauczyciela = NazwiskoNauczyciela;
            this.rocznik = Rocznik;
            this.uczniowie = Uczniowie;
        }

        public float SredniaKlasy()
        {
            float suma = 0f;
            float iloscUczniow = Uczniowie.Count;

            foreach (Uczen Uczen in Uczniowie)
            {
                suma += Uczen.SredniaOcen();
            }

            return suma / iloscUczniow;
        }

        public void PrintClassInfo()
        {
            void p(string s)
            {
                Console.WriteLine(s);
            }

            p($"Klasa: {NazwaKlasy}");
            p($"Wychowawca: {NazwiskoNauczyciela}");
            p($"Rocznik: {Rocznik}");
            p($"Ilosc uczniow: {Uczniowie.Count}");
            p($"Srednia ocen: {SredniaKlasy()}");

            foreach (Uczen Uczen in Uczniowie)
            {
                Uczen.PrintInfo();
            }
        }
    }
}
