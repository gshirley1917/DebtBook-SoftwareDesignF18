﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    class Debtors : IDebtors
    {
        private ObservableCollection<IDebtor> debtors;
        public Debtors()
        {
            this.debtors = new ObservableCollection<IDebtor>();
        }
        public void addDebtor(Debtor d)
        {
            this.debtors.Add(d);
        }
        public void deleteDebtor(Debtor d)
        {
            this.debtors.Remove(d);
        }
        public ObservableCollection<IDebtor> getDebtors()
        {
            return this.debtors;
        }
        public Debtor getDebtor(string debtorName)
        {
            //search array for debtor
            foreach (Debtor d in debtors)
            {
                if (debtorName.Equals(d.getName()))
                    return d;
            }
            return null;
        }
    }
}
