using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    interface IDebtors
    {
        void addDebtor(string n);
        List<IDebtor> getDebtors();
        IDebtor getDebtor(string n);
    }
}
