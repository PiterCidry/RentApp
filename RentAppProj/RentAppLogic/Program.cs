using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RentAppLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new RentContext())
            {
                var n1 = new Nieruchomosc() { Ulica = "Gramatyka", NrDomu = 10, NrMieszkania = null, KodPocztowy = "30-067", Miasto = "Kraków" };
                db.Nieruchomosci.Add(n1);
                db.SaveChanges();
                var query = from n in db.Nieruchomosci
                            orderby n.Ulica, n.NrDomu
                            select n;
                foreach (var n in query)
                {
                    Console.WriteLine(n.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
