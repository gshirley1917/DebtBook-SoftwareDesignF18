using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DebtBook.Model;
using DebtBook.View;

namespace DebtBook.ViewModel
{
    class ViewDebtorViewModel : BaseViewModel
    {
        private Debtor _selectedDebtor;
        public ViewDebtorViewModel(Debtors debtBook, String debtorName, INavigationService n)
        {
            _debtBook = debtBook;
            _selectedDebtor = _debtBook.getDebtor(debtorName);
            _nav = n;
        }
        public String SelectedDebtorName => _selectedDebtor.DebtorName;
        public ObservableCollection<IDebt> Debts => _selectedDebtor.getDebts();

        private DateTime _debtDate = DateTime.Now;
        public DateTime DebtDate
        {
            get { return _debtDate; }
            set
            {
                if (value != _debtDate)
                {
                    _debtDate = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Amount { get; set; }
        private ICommand _addDebtCommand;
        public ICommand AddDebtCommand
        {
            get
            {
                return _addDebtCommand ?? (_addDebtCommand =
                    new RelayCommand(AddDebt));
            }
        }
        private void AddDebt()
        {
            _selectedDebtor.addDebt(Amount, _debtDate);
            OnPropertyChanged();
        }
    }
}
