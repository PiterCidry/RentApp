using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAppLogic
{
    class Nieruchomosc
    {
        private string ulica;
        private string miasto;
        private int nrDomu;
        private int nrMieszkania;
        private string kodPocztowy;

        public string Ulica
        {
            get
            {
                return ulica;
            }

            set
            {
                ulica = value;
            }
        }

        public string Miasto
        {
            get
            {
                return miasto;
            }

            set
            {
                miasto = value;
            }
        }

        public int NrDomu
        {
            get
            {
                return nrDomu;
            }

            set
            {
                nrDomu = value;
            }
        }

        public int NrMieszkania
        {
            get
            {
                return nrMieszkania;
            }

            set
            {
                nrMieszkania = value;
            }
        }

        public string KodPocztowy
        {
            get
            {
                return kodPocztowy;
            }

            set
            {
                kodPocztowy = value;
            }
        }
    }
}
