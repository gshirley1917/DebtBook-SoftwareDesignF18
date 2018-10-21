using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebtBook.ViewModel;

namespace DebtBook.View
{ 
    interface INavigationService
    {
        void Show(BaseViewModel vm);
        void Close();
    }
}
