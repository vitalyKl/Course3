using System;
using System.Collections.Generic;
using System.Text;

namespace Course3.Models
{
    public class Recipient
    {
        private string _surname;
        private string _name;
        private string _patronymic;
        private string _birthDate;
        private string _mailAdress;

        public string Surname { get => _surname; set => _surname = value; }
        public string Name { get => _name; set => _name = value; }
        public string Patronymic { get => _patronymic; set => _patronymic = value; }
        public string BirthDate { get => _birthDate; set => _birthDate = value; }
        public string MailAdress { get => _mailAdress; set => _mailAdress = value; }
    }
}
