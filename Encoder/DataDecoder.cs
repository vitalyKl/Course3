using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using static Encoder.Entropy;

namespace Encoder
{
    public class DataDecoder
    {
        private string _revieldPassword;
        public string RevieldPassword { get => _revieldPassword; private set => _revieldPassword = value; }

        public DataDecoder(string login, string protectedPassword)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(protectedPassword))
                return;
            byte[] pass = Convert.FromBase64String(protectedPassword);
            byte[] entropy = GetEntropy(login);
            pass = ProtectedData.Unprotect(pass, entropy, DataProtectionScope.LocalMachine);
            RevieldPassword = Encoding.UTF8.GetString(pass);
        }        
    }
}
