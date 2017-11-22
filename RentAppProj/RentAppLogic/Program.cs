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
           
           // BazaNieruchomosci baza = new BazaNieruchomosci();
            Nieruchomosc n1 = new Nieruchomosc() { Ulica = "Szymały", NrDomu = 12, KodPocztowy = "41-922", Miasto = "Radzionków" };
            Nieruchomosc n2 = new Nieruchomosc() { Ulica = "Kwiatowa", NrDomu = 5, NrMieszkania = 156, KodPocztowy = "25-125", Miasto = "Kraków" };
            //baza.dodajNieruchomosc(n1);
            //baza.dodajNieruchomosc(n2);


            using (var db = new RentContext())
            {
                db.Nieruchomosci.Add(n1);
                db.Nieruchomosci.Add(n2);
                db.SaveChanges();
            }



            //baza.wypiszWszystkie();
            //Console.WriteLine("=========================\n");
            //baza.usunNieruchomosc("Kwiatowa", 5, 156, "Kraków");
            //baza.wypiszWszystkie();
            //Console.WriteLine("=========================\n");
            //baza.usunNieruchomosc("Test", 5, 156, "Test");
            //baza.wypiszWszystkie();
            Console.ReadLine();
        }
    }
}
