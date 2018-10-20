using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtBook.ViewModel;
using DebtBook.Model;

namespace DebtBook.View
{
    class Locator
    {
        Debtors debtBook = new Debtors();
        public AddDebtorViewModel AddDebtorVM => new AddDebtorViewModel(debtBook);
        public ViewDebtorViewModel ViewDebtorVM => new ViewDebtorViewModel(debtBook);
        public MainWindowViewModel MainWindowVM => new MainWindowViewModel(debtBook);
    }
}
