using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.Model;
using System.Collections.ObjectModel;
using DebtBook.View;

namespace DebtBook.ViewModel
{
    class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(Debtors debtBook, INavigationService n)
        {
            _debtBook = debtBook;
            _debtBook.addDebtor(new Debtor("Alicja"));
            _debtBook.addDebtor(new Debtor("Garrett"));
            _nav = n;
        }

        public ObservableCollection<IDebtor> DebtBook
        {
            get => _debtBook.getDebtors();
        }

        private ICommand _createDebtorCommand;
        public ICommand CreateDebtorCommand
        {
            get
            {
                return _createDebtorCommand ?? (_createDebtorCommand =
                    new RelayCommand(CreateDebtor));
            }
        }
        private void CreateDebtor()
        {
            //navigate to new window
            AddDebtorViewModel vm = new AddDebtorViewModel(_debtBook, _nav);
            _nav.Show(vm);
        }
        private ICommand _viewDebtorCommand;
        public ICommand ViewDebtorCommand
        {
            get
            {
                return _viewDebtorCommand ?? (_viewDebtorCommand =
                    new RelayCommand(ViewDebtor));
            }
        }
        public int CurrentIndex { get; set; }
        private void ViewDebtor()
        {
            ViewDebtorViewModel vm = new ViewDebtorViewModel(_debtBook, _debtBook.getDebtors()[CurrentIndex].getName(), _nav);
            _nav.Show(vm);
        }


    }
}
