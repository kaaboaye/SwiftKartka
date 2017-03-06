using System;

namespace SwiftKartka
{
    public class Zameldowanie
    {
        private string ulica;
        private string kodPocztowy;
        private string numerDomu;

        public string Ulica
        {
            get => ulica;
            set
            {
                ulica = value;
            }
        }

        public string KodPocztowy
        {
            get => kodPocztowy;
            set
            {
                if (value.Length == 6)
                {
                    kodPocztowy = value;
                }
                else
                {
                    throw new Exception("Zły kod pocztowy");
                }
            }
        }

        public string NumerDomu
        {
            get => numerDomu;
            set
            {
                numerDomu = value;
            }
        }

        public Zameldowanie(
            string KodPocztowy,
            string Ulica,
            string NumerDomu
            )
        {
            this.KodPocztowy = KodPocztowy;
            this.Ulica = Ulica;
            this.NumerDomu = NumerDomu;
        }
    }
}
