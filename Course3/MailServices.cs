using System;
using System.Collections.Generic;
using System.Text;

namespace Course3
{
    public static class MailServices
    {       
        public static List<string> Services = new List<string>()
        {
            "yandex, smtp.yandex.ru, 25",
            "gmail, smtp.gmail.com, 465",
            "mail.ru, smtp.mail.ru, 465",
        };
    }
}
