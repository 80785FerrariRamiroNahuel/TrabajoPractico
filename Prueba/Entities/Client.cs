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
        private string TypeDocument;
        private string District;
        public Client(string Name, string Surname, string Phone, string Cuit, string Mail, string typeDocument, string NumberDocument, string Address, string NumberAdrress, string District)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
            this.CUIT = Cuit;
            this.Mail = Mail;
            this.TypeDocument = typeDocument;
            this.NumberDocument = NumberDocument;
            this.Adrress = Address;
            this.NumberAdrress = NumberAdrress;
            this.District = District;
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
        public string PhoneClient
        {
            get => Phone;
            set => Phone = value;
        }
        public string CuitClient
        {
            get => CUIT;
            set => CUIT = value;
        }
        public string MailClient
        {
            get => Mail;
            set => Mail = value;
        }
        public string TypeDocumentClient
        {
            get => TypeDocument;
            set => TypeDocument = value;
        }
        public string AdrressClient
        {
            get => Adrress;
            set => Adrress = value;
        }
        public string NumberAdrressClient
        {
            get => NumberAdrress;
            set => NumberAdrress = value;
        }
        public string DistrictClient
        {
            get => District;
            set => District = value;
        }
    }

}

