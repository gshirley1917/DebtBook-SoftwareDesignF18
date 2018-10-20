using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debtor : IDebtor
    {
        public String DebtorName { get; set;}
        public Double TotalDebt { get { return getTotal(); } private set { } }
        private ObservableCollection<IDebt> debts;
        public Debtor()
        {
            this.DebtorName = null;
            this.debts = new ObservableCollection<IDebt>();
        }
        public Debtor(String name)
        {
            this.DebtorName = name;
            this.debts = new ObservableCollection<IDebt>();
        }
        public void addDebt(double debt, DateTime date)
        {
            this.debts.Add(new Debt(debt, date));
        }
        public ObservableCollection<IDebt> getDebts()
        {
            return this.debts;
        }
        public double getTotal()
        {
            double total = 0;
            foreach(Debt d in debts)
            {
                total += d.Amount;
            }
            return total;
        }
        public string getName()
        {
            return this.DebtorName;
        }
    }
}
