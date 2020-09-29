using System;
using System.Security.Cryptography;
using System.Text;
using static Encoder.Entropy;

namespace Encoder
{
    public class DataEncoder
    {
        public string protectedPassword { get; private set; }
        public DataEncoder(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return;
            byte[] pass = Encoding.UTF8.GetBytes(password);
            byte[] entropy = GetEntropy(login);
            byte[] crypted = ProtectedData.Protect(pass, entropy, DataProtectionScope.LocalMachine);
            protectedPassword = Convert.ToBase64String(crypted);
        }        

    }
}
