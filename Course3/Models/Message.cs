using System;
using System.Collections.Generic;
using System.Text;

namespace Course3.Models
{
    public class Message
    {
        private string _subject;
        private string _body;

        public string Subject { get => _subject; set => _subject = value; }
        public string Body { get => _body; set => _body = value; }
    }
}
