using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAppLogic
{
    public class BazaNieruchomosci
    {
        public List<Nieruchomosc> nieruchomosci;

        public BazaNieruchomosci()
        {
            this.nieruchomosci = new List<Nieruchomosc>();
        }

        public void dodajNieruchomosc(Nieruchomosc n)
        {
            this.nieruchomosci.Add(n);
        }

        public void usunNieruchomosc(string ulica, int nrDomu, int nrMieszkania, string miasto)
        {
            this.nieruchomosci.Remove(this.nieruchomosci.Find(x => x.Ulica == ulica && x.NrDomu == nrDomu && x.NrMieszkania == nrMieszkania && x.Miasto == miasto));
        }

        public void usunNieruchomosc(int id)
        {
            this.nieruchomosci.Remove(this.nieruchomosci.Find(x => x.Id == id));
        }

        public void usunNieruchomosc(Nieruchomosc n)
        {
            this.nieruchomosci.Remove(n);
        }

        public void wypiszWszystkie()
        {
            nieruchomosci.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
