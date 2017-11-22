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
        public int Id { get; set; }
        private string ulica;
        private string miasto;
        private int nrDomu;
        private int? nrMieszkania;
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

        public Nieruchomosc()
        {

        }

        public Nieruchomosc(string ulica, string miasto, int nrDomu, int? nrMieszkania, string kodPocztowy)
        {
            this.ulica = ulica;
            this.miasto = miasto;
            this.nrDomu = nrDomu;
            this.nrMieszkania = nrMieszkania;
            this.kodPocztowy = kodPocztowy;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Mieszkanie nr ").Append(this.Id);
            sb.AppendLine().Append("Ulica: ").Append(this.Ulica).Append(" ");
            if(this.NrMieszkania == null)
            {
                sb.Append(this.NrDomu);
            }
            else
            {
                sb.Append(this.NrDomu).Append("/").Append(this.NrMieszkania);
            }
            sb.AppendLine().Append("Miasto: ").Append(this.Miasto);
            sb.AppendLine().Append("Kod pocztowy: ").Append(this.KodPocztowy).AppendLine();
            return sb.ToString();
        }
    }
}
