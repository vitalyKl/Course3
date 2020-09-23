using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Windows;

namespace Course3
{
    class MailSender
    {
        IMailData _mailData;
        private MailMessage _mm;
        private SmtpClient _sc;

        public MailSender(IMailData mailData, ObservableCollection<MailService> services)
        {
            _mailData = mailData;
            var selectedService = services.Where(x => x.Name == _mailData.SeviceName).FirstOrDefault();

            var from = new MailAddress($"{_mailData.ServiceLogin}{selectedService.ServiceDomain}");
            var to = new MailAddress($"{_mailData.MailReciever}");
            _mm = new MailMessage(from, to);
            _mm.Subject = _mailData.MailTitle;
            _mm.Body = _mailData.MailText;
            _mm.IsBodyHtml = false;

            _sc = new SmtpClient(selectedService.Url, selectedService.Port);
            _sc.EnableSsl = true;
            _sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            _sc.UseDefaultCredentials = false;
            if (selectedService.IsSecurePasswordNeeded == true)
            {
                _sc.Credentials = new NetworkCredential()
                {
                    UserName = $"{_mailData.ServiceLogin}{selectedService.ServiceDomain}",
                    SecurePassword = _mailData.SecureServicePassword
                };
            }
            else
            {
                _sc.Credentials = new NetworkCredential()
                {
                    UserName = $"{_mailData.ServiceLogin}{selectedService.ServiceDomain}",
                    Password = _mailData.ServicePassword
                };
            }
        }

        public string SendMessage()
        {
            string status = "";
            try
            {
                _sc.Send(_mm);
                status = "Сообщение успешно отправлено!";
            }
            catch 
            {
                status = "Ошибка при отправке сообщения! Проверьте входящие данные!";
            }
            return status;
        }
    }
}
