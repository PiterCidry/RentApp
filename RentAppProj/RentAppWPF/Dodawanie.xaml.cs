using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RentAppLogic;

namespace RentApp
{
    /// <summary>
    /// Interaction logic for Dodawanie.xaml
    /// </summary>
    public partial class Dodawanie : Window
    {
        Nieruchomosc n;

        public Dodawanie()
        {
            InitializeComponent();
        }

        public Dodawanie(Nieruchomosc n):this()
        {
            this.n = n;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            n.KodPocztowy = KodPocztowyTB.Text;
            n.Miasto = MiastoTB.Text;
            n.NrDomu = Int32.Parse(NrDomuTB.Text);
            n.NrMieszkania = Int32.Parse(NrMieszkaniaTB.Text);
            n.Ulica = ulicaTB.Text;
            this.Close();
        }
    }
}
