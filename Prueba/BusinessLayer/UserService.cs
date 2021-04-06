using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Entities;
using Prueba.DataAccesLayer;
namespace Prueba.BusinessLayer
{
    class UserService
    {

        public User ValidateUser(string TakeUser, string pass)
        {
            try
            {
                User user = UserDAO.GetUser(TakeUser, pass);
                int resultado = user.Perfil;
                if (resultado == 0)
                {
                    return null;
                }
                else
                {
                    return user;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        

    }
}
