using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAppLogic
{
    public class Nieruchomosc
    {
        [Key]
        private int id;
        private string ulica;
        private string miasto;
        private int nrDomu;
        private int? nrMieszkania;
        private string kodPocztowy;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public int? NrMieszkania
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mieszkanie przy ulicy: ").Append(this.Ulica).Append("\nNr domu: ").Append(this.NrDomu);
            if(this.NrMieszkania != null)
            {
                sb.Append("/").Append(this.NrMieszkania);
            }
            sb.Append("\nKod pocztowy: ").Append(this.KodPocztowy).Append("\nMiasto: ").Append(this.Miasto);
            return sb.ToString();
        }
    }
}
