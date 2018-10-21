using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
    }
}
