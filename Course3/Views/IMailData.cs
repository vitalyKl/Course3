using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Course3
{
    interface IMailData
    {
        public string MailReciever { get; }

        public string MailTitle { get; }

        public string MailText { get; }

        public string SeviceName { get; }

        public string ServiceLogin { get; }
        
        public string ServicePassword { get; set; }

        public bool? IsSavePassword { get; set; }

        public SecureString SecureServicePassword { get; }
    }
}
