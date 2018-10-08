using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    interface IDebtor
    {
        void addDebt(double amount, DateTime date);
        //TODO functions for getting amount, name, date
    }
}
