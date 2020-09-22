using System;
using System.Collections.Generic;
using System.Text;

namespace Course3
{
    interface IMailData
    {
        public string MailSender { get; set; }

        public string MailReciever { get; set; }

        public string MailTitle { get; set; }

        public string MailText { get; set; }

        public string SeviceName { get; set; }

        public string ServiceLogin { get; set; }

        public string ServicePassword { get; set; }
        
    }
}
