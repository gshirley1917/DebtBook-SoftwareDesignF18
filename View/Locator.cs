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
        NavigationService nav = new NavigationService();
        public AddDebtorViewModel AddDebtorVM => new AddDebtorViewModel(debtBook, nav);
        public ViewDebtorViewModel ViewDebtorVM => new ViewDebtorViewModel(debtBook, "Alicja", nav);
        public MainWindowViewModel MainWindowVM => new MainWindowViewModel(debtBook, nav);
    }
}
