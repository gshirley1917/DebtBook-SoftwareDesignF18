using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtBook.Model;

namespace DebtBook.ViewModel
{
    //TODO
    class ViewDebtorViewModel : INotifyPropertyChanged
    {
        private Debtors _debtBook;
        public ViewDebtorViewModel(Debtors debtBook)
        {
            _debtBook = debtBook;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
