using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DebtBook.ViewModel;

namespace DebtBook.View
{
    class NavigationService : INavigationService
    {
        Window currentWindow;
        public void Show(BaseViewModel vm)
        {
            switch (vm.GetType().Name)
            {
                case "AddDebtorViewModel" :
                    currentWindow = new AddDebtor();
                    currentWindow.ShowDialog();
                    break;
                case "ViewDebtorViewModel":
                    currentWindow = new ViewDebtor();
                    currentWindow.DataContext = vm;
                    currentWindow.ShowDialog();
                    break;
            }
        }

        public void Close()
        {
            currentWindow.Close();
        }
    }
}
