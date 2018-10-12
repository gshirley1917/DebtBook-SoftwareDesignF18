using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    interface IDebt
    {
        double getAmount();
        DateTime getDate();
    }
}
