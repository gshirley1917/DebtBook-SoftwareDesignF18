using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debt : IDebt
    {
        private double amount;
        private DateTime date;
        public Debt(double debt, DateTime date)
        {
            this.amount = debt;
            this.date = date;
        }
        public double getAmount()
        {
            return this.amount;
        }
        public DateTime getDate()
        {
            return this.date;
        }

    }
}
