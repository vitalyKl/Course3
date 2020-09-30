using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Encoder
{
    public static class Entropy
    {

        public static byte[] GetEntropy(string entropyString)
        {
            MD5 md5 = MD5.Create();
            return md5.ComputeHash(Encoding.UTF8.GetBytes(entropyString));
        }
    }
}
