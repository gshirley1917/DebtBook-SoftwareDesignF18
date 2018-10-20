using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debt : IDebt
    {
        public double Amount { get; private set; }
        public DateTime Date { get; private set; }
        public Debt(double debt, DateTime date)
        {
            this.Amount = debt;
            this.Date = date;
        }
        /*public double getAmount()
        {
            return this.Amount;
        }
        public DateTime getDate()
        {
            return this.Date;
        }*/

    }
}
