﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.Model
{
    interface IDebtor
    {
        void addDebt(double amount, DateTime date);
        List<IDebt> getDebts();
        double getTotal();
    }
}
