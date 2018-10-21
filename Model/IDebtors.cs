using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    interface IDebtors
    {
        void addDebtor(Debtor d);
        ObservableCollection<IDebtor> getDebtors();
        Debtor getDebtor(String name);
    }
}
