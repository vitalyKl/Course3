using Course3.Models;
using Course3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security;
using System.Text;

namespace Course3.ViewModels
{
    class SendWindowViewModel: ViewModel, IMailData
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>();
        private ObservableCollection<MailService> _services = new ObservableCollection<MailService>();
        private ObservableCollection<Recipient> _recipients = new ObservableCollection<Recipient>();
        private ObservableCollection<Message> _messages = new ObservableCollection<Message>();

        public ObservableCollection<string> MailReciever { get; set; }
        public string MailTitle { get; set; }
        public string MailText { get; set; }
        public string SeviceName { get; set; }
        public string ServiceLogin { get; set; }
        public string ServicePassword { get; set; }
        public bool? IsSavePassword { get; set; }
        public SecureString SecureServicePassword { get; set; }


        public ObservableCollection<MailService> Services 
        { 
            get => _services; 
            set => Set(ref _services, value); 
        }
        public ObservableCollection<Recipient> Recipients 
        { 
            get => _recipients; 
            set => Set(ref _recipients, value); 
        }
        public ObservableCollection<Message> Messages 
        { 
            get => _messages; 
            set => Set(ref _messages, value); 
        }
        internal ObservableCollection<User> Users 
        { 
            get => _users; 
            set => Set(ref _users, value); 
        }
    }
}
