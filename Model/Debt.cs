using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debt
    {
        private double amount;
        private DateTime date;
        public Debt(double debt, DateTime date)
        {
            this.amount = debt;
            this.date = date;
        }
    }
}
