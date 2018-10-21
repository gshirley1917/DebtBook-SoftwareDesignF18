using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    interface IDebtor
    {
        void addDebt(double amount, DateTime date);
        ObservableCollection<IDebt> getDebts();
        string getName();
        double getTotal();
    }
}
