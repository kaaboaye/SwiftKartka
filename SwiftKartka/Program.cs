using System;
using System.Collections.Generic;

namespace SwiftKartka
{
    class Program
    {
        static void Main(string[] args)
        {
            var GejBi = new Klasa(
                NazwaKlasy: "3gejbi",
                NazwiskoNauczyciela: "No jakis pewnie jest",
                Rocznik: 1998,
                Uczniowie: new List<Uczen>()
                    {
                        new Uczen(
                            Imie: "Franek",
                            Nazwisko: "Kowalski",
                            DataUrodzenia: "22.12.1998",
                            AdresZamieszkania: new Zameldowanie(
                                KodPocztowy: "64-100",
                                Ulica: "Wiejska",
                                NumerDomu: "3/4"
                                )
                            )
                        {
                            Oceny = new List<byte>()
                            {
                                2,
                                3,
                                5,
                                6,
                                1,
                                1,
                            }
                        },
                        new Uczen(
                            Imie: "Jendzej",
                            Nazwisko: "PKleszcz",
                            DataUrodzenia: "13.13.1998",
                            AdresZamieszkania: new Zameldowanie(
                                KodPocztowy: "00-000",
                                Ulica: "Wiejska",
                                NumerDomu: "6/9"
                                )
                            )
                        {
                            Oceny = new List<byte>()
                            {
                                1,
                                1,
                                1,
                                1,
                                2,
                                1,
                                1,
                            }
                        }
                    }
                );

            GejBi.PrintClassInfo();

            Console.ReadLine();
        }
    }
}