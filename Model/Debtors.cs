using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debtors : IDebtors
    {
        private List<IDebtor> debtors;
        public Debtors()
        {
            this.debtors = new List<IDebtor>();
        }
        public void addDebtor(String name)
        {
            this.debtors.Add(new Debtor(name));
        }
        public void addDebtor(String name, double initial)
        {
            this.debtors.Add(new Debtor(name, initial));
        }
    }
}
