using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp
{
    class Fake
    {
        string nazwa;
        DateTime poczatek;
        DateTime koniec;

        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {
                nazwa = value;
            }
        }

        public DateTime Poczatek
        {
            get
            {
                return poczatek;
            }

            set
            {
                poczatek = value;
            }
        }

        public DateTime Koniec
        {
            get
            {
                return koniec;
            }

            set
            {
                koniec = value;
            }
        }

        public Fake(string nazwa, DateTime poczatek, DateTime koniec)
        {
            this.Nazwa = nazwa;
            this.Poczatek = poczatek;
            this.Koniec = koniec;
        }
    }
}
