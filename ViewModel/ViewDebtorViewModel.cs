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
    //TODO
    class ViewDebtorViewModel : INotifyPropertyChanged
    {
        private Debtors _debtBook;
        private Debtor _selectedDebtor;
        private INavigationService _nav;
        public ViewDebtorViewModel(Debtors debtBook, String debtorName, INavigationService n)
        {
            _debtBook = debtBook;
            _selectedDebtor = _debtBook.getDebtor(debtorName);
            _nav = n;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public String SelectedDebtorName => _selectedDebtor.DebtorName;
        public ObservableCollection<IDebt> Debts => _selectedDebtor.getDebts();

        public DateTime DebtDate { get; set; }
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
            _debtBook.getDebtor(_debtorName).addDebt(Amount, DebtDate);
        }
    }
}
