using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debtor : IDebtor
    {
        private String name;
        private List<Debt> debts;

        public Debtor(String n)
        {
            this.name = n;
            this.debts = new List<Debt>();
        }
        public Debtor(String n, double initial)
        {
            this.name = n;
            this.debts = new List<Debt>();
            this.debts.Add(new Debt(initial, DateTime.Now));
        }
        public void addDebt(Debt d)
        {
            this.debts.Add(d);
        }
        public void addDebt(double debt)
        {
            this.debts.Add(new Debt(debt, DateTime.Now));
        }
        public void addDebt(double debt, DateTime date)
        {
            this.debts.Add(new Debt(debt, date));
        }
    }
}
