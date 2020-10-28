using Course3.Infrasrtucture;
using Course3.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Course3
{
   
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>();
        private UserWorker _uw = new UserWorker();

        public MainWindow()
        {
            InitializeComponent();
            _users = _uw.ReadUsers();
        }
    }
}
