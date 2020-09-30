using System;
using System.Security.Cryptography;
using System.Text;
using static Encoder.Entropy;

namespace Encoder
{
    public class DataEncoder
    {
        public string ProtectedPassword { get; private set; }
        public DataEncoder(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return;
            byte[] pass = Encoding.UTF8.GetBytes(password);
            byte[] entropy = GetEntropy(login);
            byte[] crypted = ProtectedData.Protect(pass, entropy, DataProtectionScope.LocalMachine);
            ProtectedPassword = Convert.ToBase64String(crypted);
        }        

    }
}
