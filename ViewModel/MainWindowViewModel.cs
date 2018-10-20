using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.Model;

namespace DebtBook.ViewModel
{
    //TODO 
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Debtors _debtBook;
        public MainWindowViewModel(Debtors debtBook)
        {
            _debtBook = debtBook;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
