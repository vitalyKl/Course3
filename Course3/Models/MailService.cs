using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Course3
{
    public class MailService
    {
        private string _name;
        private string _url;
        private int _port;
        private string _serviceDomain;
        private bool _isSecurePasswordNeeded;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public string Url
        {
            get => _url;
            private set => _url = value;
        }
        public int Port
        {
            get => _port;
            private set => _port = value;
        }
        public string ServiceDomain
        {
            get => _serviceDomain;
            private set => _serviceDomain = value;
        }
        public bool IsSecurePasswordNeeded { get => _isSecurePasswordNeeded; set => _isSecurePasswordNeeded = value; }

        Regex reg = new Regex(@"(?<name>\w*\.*\w*)\s(?<url>\w*\.\w*\.\w*)\s(?<port>\d*)\s(?<securePasswordStatus>\w*)", RegexOptions.Compiled);

        public MailService(string input)
        {
            var match = reg.Match(input);
            if (match == null) return;
            Name = match.Groups["name"].Value;
            Url = match.Groups["url"].Value;
            Port = Convert.ToInt32(match.Groups["port"].Value);
            IsSecurePasswordNeeded = Convert.ToBoolean(match.Groups["securePasswordStatus"].Value);
            ServiceDomain = "@" + Url.Substring(Url.IndexOf('.') + 1);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
