using System;
using System.Collections.Generic;
using System.Text;

namespace Course3.Models
{
    class Server
    {
        private int _Port;

        public string Adress { get; set; }
        public int Port 
        { 
            get => _Port; 
            set
            {
                if (value < 0 || value > 65535)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "Номер порта должен быть в диапазоне от 0 до 65535");                    
                }
                _Port = value;
            }
        }
        public bool UseSSL { get; set; }
        public string Description { get; set; }
    }
}
