﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DebtBook.Model;
using System.Collections.ObjectModel;
using DebtBook.View;

namespace DebtBook.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Debtors _debtBook;
        private INavigationService _nav;
        public MainWindowViewModel(Debtors debtBook, INavigationService n)
        {
            _debtBook = debtBook;
            _debtBook.addDebtor(new Debtor("Alicja"));
            _debtBook.addDebtor(new Debtor("Garrett"));
            _nav = n;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<IDebtor> DebtBook
        {
            get => _debtBook.getDebtors();
        }

        private ICommand _createDebtorCommand;
        public ICommand CreateDebtorCommand
        {
            get
            {
                return _createDebtorCommand ?? (_createDebtorCommand =
                    new RelayCommand(CreateDebtor));
            }
        }
        private void CreateDebtor()
        {
            //navigate to new window
            AddDebtorViewModel vm = new AddDebtorViewModel(_debtBook, _nav);
            _nav.Show("AddDebtor");
        }



    }
}
