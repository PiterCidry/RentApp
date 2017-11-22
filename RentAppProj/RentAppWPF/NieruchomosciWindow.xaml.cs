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
using System.Diagnostics;

namespace RentApp
{
    /// <summary>
    /// Interaction logic for NieruchomosciWindow.xaml
    /// </summary>
    public partial class NieruchomosciWindow : Window
    {
        public BazaNieruchomosci baza;

        public NieruchomosciWindow()
        {
            InitializeComponent();
            baza = new BazaNieruchomosci();
            Nieruchomosci.ItemsSource = baza.nieruchomosci;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Nieruchomosc n1 = new Nieruchomosc();
            Dodawanie d = new Dodawanie(n1);
            if(d.ShowDialog() != false)
            {
                baza.dodajNieruchomosc(n1);
            }
            Nieruchomosci.Items.Refresh();
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            Nieruchomosc n = Nieruchomosci.SelectedItem as Nieruchomosc;
            if(n != null)
            {
                baza.usunNieruchomosc(n);
            }
            Nieruchomosci.Items.Refresh();
        }
    }
}
