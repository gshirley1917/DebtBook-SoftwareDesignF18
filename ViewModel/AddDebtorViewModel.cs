using DebtBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.View;

namespace DebtBook.ViewModel
{
    class AddDebtorViewModel : INotifyPropertyChanged
    {
        private IDebtors _debtBook;
        private INavigationService _nav;
        public AddDebtorViewModel(Debtors debtBook, INavigationService n)
        {
            _debtBook = debtBook;
            _nav = n;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        Debtor debtor = new Debtor();
        private double initialDebt = 0;
        public string Name
        {
            get => debtor.DebtorName;
            set
            {
                if(value != debtor.DebtorName)
                {
                    debtor.DebtorName = value;
                    OnPropertyChanged();
                }
            }
        }
        public double InitialDebt
        {
            get{ return initialDebt; }
            set
            {
                if (value != initialDebt)
                {
                    initialDebt = value;
                    OnPropertyChanged();
                }
            }
        }
        private ICommand _addDebtorCommand;
        public ICommand AddDebtorCommand
        {
            get
            {
                return _addDebtorCommand ?? (_addDebtorCommand =
                    new RelayCommand(AddDebtor));
            }
        }
        private void AddDebtor()
        {
            debtor.addDebt(initialDebt, DateTime.Now);
            _debtBook.addDebtor(debtor);
            _nav.Close();
        }

        private ICommand _cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                return _cancelCommand ?? (_cancelCommand =
                    new RelayCommand(Cancel));
            }
        }

        private void Cancel()
        {
            _nav.Close();
        }
    }
}
