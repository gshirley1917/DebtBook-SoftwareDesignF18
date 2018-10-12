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
        public List<IDebtor> getDebtors()
        {
            return this.debtors;
        }
        public IDebtor getDebtor(string debtorName)
        {
            //TODO search array for debtor, return that debtor
            //Needed for list view in window
            return this.debtors[0];
        }
    }
}
