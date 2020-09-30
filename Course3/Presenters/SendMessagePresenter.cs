using Course3.Infrasrtucture;
using Course3.Models;
using Encoder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace Course3.Presenters
{

    class SendMessagePresenter
    {
        private MailSender _ms;
        private IMailData _mailData;
        private UserWorker uw = new UserWorker();
        private DataDecoder _dd;
        public ObservableCollection<User> UsersList = new ObservableCollection<User>();
        public ObservableCollection<MailService> services = new ObservableCollection<MailService>();

        public SendMessagePresenter(IMailData mailData)
        {
            _mailData = mailData;
            FillMailServices();
            UsersList = uw.ReadUsers();            
        }

        private void FillMailServices()
        {
            using (StreamReader sr = new StreamReader(@"Resources\MailServicesData.txt"))
            {
                while (!sr.EndOfStream)
                {
                    services.Add(new MailService(sr.ReadLine()));
                }
            }
        }

        public string SendMessage()
        {
            string summary = "";
            var x = UsersList.Where(x => x.Login == _mailData.ServiceLogin).FirstOrDefault();
            if(x != null)
            {
                _dd = new DataDecoder(x.Login, x.Password);
                _mailData.ServicePassword = _dd.RevieldPassword;
                _ms = new MailSender(_mailData, services);
            }
            else
            _ms = new MailSender(_mailData, services);
           return summary = _ms.SendMessage();
        }
    }
}
