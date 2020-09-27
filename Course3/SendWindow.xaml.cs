using Course3.Presenters;
using System.Security;
using System.Windows;

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
        public string ServiceLogin { get => TxtUserLogin.Text; }
        public SecureString SecureServicePassword { get => TxtUserPassword.SecurePassword; }
        public string ServicePassword { get => TxtUserPassword.Password.ToString(); }

        public SendWindow()
        {
            InitializeComponent();
            _mp = new SendMessagePresenter(this);
            LstServices.ItemsSource = _mp.services;
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            TxtResult.Text = _mp.SendMessage();
            TabCMenu.SelectedIndex++;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Show();
            this.Close();
        }

        private void BtnSendAnother_Click(object sender, RoutedEventArgs e)
        {
            Window x = new SendWindow();
            x.Show();
            this.Close();

        }

        private void ChkIsRecipientsFromDb_Checked(object sender, RoutedEventArgs e)
        {
            RecipientsBase.Visibility = Visibility.Visible;
        }

        private void ChkIsRecipientsFromDb_Unchecked(object sender, RoutedEventArgs e)
        {
            RecipientsBase.Visibility = Visibility.Hidden;
        }

        private void OpenTemplate_Click(object sender, RoutedEventArgs e)
        {
            SelectMessageTemplate.Visibility = Visibility.Visible;
            TabCMenu.SelectedValue = SelectMessageTemplate;
            TabCMenu.IsManipulationEnabled = false;
        }

        private void SelectMessageTemplate_LostFocus(object sender, RoutedEventArgs e)
        {
            SelectMessageTemplate.Visibility = Visibility.Collapsed;
        }

        private void BtnApplyRecipients_Click(object sender, RoutedEventArgs e)
        {
            _mp.SendMessage();
        }
    }
}
