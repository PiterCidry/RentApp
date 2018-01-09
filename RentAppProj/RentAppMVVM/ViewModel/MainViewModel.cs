using GalaSoft.MvvmLight;
using RentAppLogic;
using System.Collections.ObjectModel;

namespace RentAppMVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private RentContext _ctx;
        private ObservableCollection<Nieruchomosc> nieruchomosci;
        public ObservableCollection<Nieruchomosc> Nieruchomosci
        {
            get
            {
                return nieruchomosci;
            }
            set
            {
                nieruchomosci = value;
                
            }
        }

        public MainViewModel()
        {
            _ctx = new RentContext();
            Refresh();
        }

        public void Refresh()
        {
            Nieruchomosci = _ctx.Nieruchomosci.Local;
        }
    }
}