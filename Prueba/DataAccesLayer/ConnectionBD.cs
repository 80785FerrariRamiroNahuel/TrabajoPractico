using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Prueba.DataAccesLayer
{
    class ConnectionBD
    {
        private SqlConnection cone;
        private static ConnectionBD instance;
        public ConnectionBD()
        {
            string connectionBD = System.Configuration.ConfigurationManager.AppSettings["ConnectionBD"];
            SqlConnection cone = new SqlConnection(connectionBD);
            

        }
        public static ConnectionBD GetInstance()
        {
            if (instance == null)
                instance = new ConnectionBD();

            instance.Open();

            return instance;
        }
        public void Open()
        {
            if (cone.State != ConnectionState.Open)
                cone.Open();
            
        }

        public void Close()
        {
            if (cone.State != ConnectionState.Closed)
                cone.Close();

        }
    }
}
