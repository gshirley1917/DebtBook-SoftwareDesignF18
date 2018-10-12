using DebtBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace DebtBook.ViewModel
{
    class AddDebtorViewModel
    {
        Debtor debtor = new Debtor();
        public string Name
        {
            get => debtor.name;
            set
            {
                if(value != debtor.name)
                {
                    debtor.name = value;
                    //OnPropertyChanged();
                }
            }
        }
        public double InitialDebt;
    }
}
