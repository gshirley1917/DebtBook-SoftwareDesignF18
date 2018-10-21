using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtBook.View
{ 
    interface INavigationService
    {
        void Show(String viewName);
        void Close();
    }
}
