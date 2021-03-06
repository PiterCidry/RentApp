﻿using System;
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
        public RentContext db;

        public NieruchomosciWindow()
        {
            InitializeComponent();
            baza = new BazaNieruchomosci();
            db = new RentContext();
            gridNieruchomosci.ItemsSource = db.Nieruchomosci.ToList();
            //Nieruchomosci.ItemsSource = baza.nieruchomosci;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Nieruchomosc n1 = new Nieruchomosc();
            Dodawanie d = new Dodawanie(n1);
            d.ShowDialog();
            if(d.DialogResult != false)
            {
                db.Nieruchomosci.Add(n1);
                db.SaveChanges();
                //baza.dodajNieruchomosc(n1);
            }
            gridNieruchomosci.ItemsSource = db.Nieruchomosci.ToList();
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            Nieruchomosc n = gridNieruchomosci.SelectedItem as Nieruchomosc;
            if(n != null && MessageBox.Show("Czy napewno?", "UWAGA!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                db.Nieruchomosci.Remove(n);
                db.SaveChanges();
                //baza.usunNieruchomosc(n);
                gridNieruchomosci.ItemsSource = db.Nieruchomosci.ToList();
            }
        }
    }
}
