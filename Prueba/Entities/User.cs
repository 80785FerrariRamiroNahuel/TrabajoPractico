using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities
{
    public class User
    {
        private string NameUser;
        private string Pass;

        public User(string NameUser, string Pass)
        {
            this.NameUser = NameUser;
            this.Pass = Pass;

        }

        public string nameUser
        {
            get => NameUser;
            set => NameUser = value;
        }
        public string password
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
