using GalaSoft.MvvmLight;
using RentAppLogic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;

namespace RentAppMVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
      private RentContext _ctx;
      private ObservableCollection<Nieruchomosc> nieruchomosci;

        public ObservableCollection<Nieruchomosc> Nieruchomosci
        {
            get { return nieruchomosci; }
            set { nieruchomosci = value;
                RaisePropertyChanged("Nieruchomosci");
            }
        }

        public MainViewModel()
        {
            _ctx = new RentContext();
            Refresh();
        }

        public void Refresh()
        {
            _ctx.Nieruchomosci.Load();
            Nieruchomosci =_ctx.Nieruchomosci.Local;
            return;
        }
    }
}