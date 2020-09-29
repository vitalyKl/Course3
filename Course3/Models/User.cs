using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security;
using System.Text;

namespace Course3.Models
{
    class User
    {
        private string _service;
        private string _login;
        private string _password;

        public string Login { get => _login; private set => _login = value; }
        public string Password { get => _password; private set => _password = value; }
        public string Service { get => _service; set => _service = value; }

        public User(string service, string login, string password)
        {
            Service = service;
            Login = login;
            Password = password;
        }

    }
}
