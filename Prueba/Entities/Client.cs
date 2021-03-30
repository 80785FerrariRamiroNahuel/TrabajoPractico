using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities
{
    class Client
    {
        private string Name;
        private string Surname;
        private string Phone;
        private string CUIT;
        private string Mail;
        private string Adrress;
        private string NumberAdrress;
        private string NumberDocument;
        public Client(string Name, string Surname,string Phone,string Cuit , string Mail, string Address ,string NumberAdrress,string NumberDocument)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
            this.CUIT = Cuit;
            this.Mail = Mail;
            this.Adrress = Address;
            this.NumberAdrress = NumberAdrress;
            this.NumberDocument = NumberDocument;
        }

        public string DocumentClient
        {
            get => NumberDocument;
            set => NumberDocument = value;
        }
        public string SurnameClient
        {
            get => Surname;
            set => Surname = value;
        }
        public string NameClient
        {
            get => Name;
            set => Name = value;
        }
    }
}
