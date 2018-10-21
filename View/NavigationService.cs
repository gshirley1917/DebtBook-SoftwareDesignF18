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
        Window currentWindow;
        public void Show(String viewName)
        {
            switch (viewName)
            {
                case "AddDebtor":
                    currentWindow = new AddDebtor();
                    currentWindow.ShowDialog();
                    break;
                case "ViewDebtor":
                    Window view = new ViewDebtor();
                    view.ShowDialog();
                    break;
            }
        }

        public void Close()
        {
            currentWindow.Close();
        }
    }
}
