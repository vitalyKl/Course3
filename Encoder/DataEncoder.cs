using System;
using System.Security.Cryptography;
using System.Text;
using static Encoder.Entropy;

namespace Encoder
{
    public class DataEncoder
    {
        private byte[] _crypted;

        public byte[] Crypted { get => _crypted; private set => _crypted = value; }

        public DataEncoder(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return;
            byte[] pass = Encoding.UTF8.GetBytes(password);
            byte[] entropy = GetEntropy(login);
            Crypted = ProtectedData.Protect(pass, entropy, DataProtectionScope.LocalMachine);
        }        

    }
}
