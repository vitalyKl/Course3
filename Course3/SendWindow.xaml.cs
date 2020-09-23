using Course3.Presenters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Course3
{
    /// <summary>
    /// Логика взаимодействия для SendWindow.xaml
    /// </summary>
    public partial class SendWindow : Window, IMailData
    {
        private SendMessagePresenter _mp;

        public string MailReciever { get => TxtRecipient.Text; }
        public string MailTitle { get => TxtSubject.Text; }
        public string MailText { get => TxtBody.Text; }
        public string SeviceName { get => LstServices.SelectedItem.ToString(); }
        public string ServiceLogin { get => ServiceLogin; }
        public string ServicePassword { get => UserPassword.SecurePassword.ToString(); }

        public SendWindow()
        {
            InitializeComponent();
            _mp = new SendMessagePresenter(this);
        }

        
    }
}
