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

namespace DebtBook.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private IDebtors _debtBook;
        public MainWindowViewModel(Debtors debtBook)
        {
            _debtBook = debtBook;
            _debtBook.addDebtor("Alicja");
            _debtBook.addDebtor("Garrett");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<IDebtor> DebtBook
        {
            get => _debtBook.getDebtors();
        }



    }
}
