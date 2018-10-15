using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debtor : IDebtor
    {
        public String name; //TODO shouldn't be private?
        private List<IDebt> debts;
        public Debtor()
        {
            this.name = null;
            this.debts = new List<IDebt>();
        }
        public Debtor(String name)
        {
            this.name = name;
            this.debts = new List<IDebt>();
        }
        public void addDebt(double debt, DateTime date)
        {
            this.debts.Add(new Debt(debt, date));
        }
        public List<IDebt> getDebts()
        {
            return this.debts;
        }
        public double getTotal()
        {
            double total = 0;
            foreach(Debt d in debts)
            {
                total += d.getAmount();
            }
            return total;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
