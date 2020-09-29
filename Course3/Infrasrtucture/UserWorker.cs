using Course3.Models;
using Encoder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Security;
using System.Text;

namespace Course3.Infrasrtucture
{
    class UserWorker
    {
        private string _login;
        private SecureString _password;
        private readonly string _dataPath = @"Resources\UsersData.txt";

        public string Login { get => _login; private set => _login = value; }
        public SecureString Password { get => _password; private set => _password = value; }

        public UserWorker()
        {
            
        }

        public ObservableCollection<User> ReadUsers()
        {
            ObservableCollection<User> users = new ObservableCollection<User>();
            string[] data = new string[3];
            using (StreamReader sr = new StreamReader(_dataPath))
            {
                while (!sr.EndOfStream)
                {
                    data = sr.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                    users.Add(new User(data[0], data[1], data[2]));
                }
            }
            return users;
        }

        public void SaveUser(string service, string login, string securedPassword)
        {
            using (StreamWriter sw = new StreamWriter(_dataPath))
            {
                sw.WriteLine($"{service};{login};{securedPassword}");
            }
            
        }
        
    }
}
