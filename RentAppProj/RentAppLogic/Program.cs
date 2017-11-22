using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAppLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var db = new RentContext())
            {
                var n1 = new Nieruchomosc() { Ulica = "Gramatyka", NrDomu = 10, KodPocztowy = "30-067", Miasto = "Kraków" };
                db.Nieruchomosci.Add(n1);
                db.SaveChanges();
                var query = from n in db.Nieruchomosci
                            orderby n.Ulica, n.NrDomu
                            select n; 
            }*/
            BazaNieruchomosci baza = new BazaNieruchomosci();
            Nieruchomosc n1 = new Nieruchomosc() { Ulica = "Szymały", NrDomu = 12, KodPocztowy = "41-922", Miasto = "Radzionków" };
            Nieruchomosc n2 = new Nieruchomosc() { Ulica = "Kwiatowa", NrDomu = 5, NrMieszkania = 156, KodPocztowy = "25-125", Miasto = "Kraków" };
            baza.dodajNieruchomosc(n1);
            baza.dodajNieruchomosc(n2);
            baza.wypiszWszystkie();
            Console.WriteLine("=========================\n");
            baza.usunNieruchomosc("Kwiatowa", 5, 156, "Kraków");
            baza.wypiszWszystkie();
            Console.WriteLine("=========================\n");
            baza.usunNieruchomosc("Test", 5, 156, "Test");
            baza.wypiszWszystkie();
            Console.ReadLine();
        }
    }
}
