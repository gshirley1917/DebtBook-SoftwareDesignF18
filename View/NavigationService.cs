using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DebtBook.View
{
    class NavigationService : INavigationService
    {
        //TODO close windows
        public void Show(String viewName)
        {
            switch (viewName)
            {
                case "AddDebtor":
                    Window w = new AddDebtor();
                    w.ShowDialog();
                    break;
            }
        }
    }
}
