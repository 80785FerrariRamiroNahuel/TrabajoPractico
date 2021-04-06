using System.Data.SqlClient;
using System.Data;
using Prueba.Entities;
using System;

namespace Prueba.DataAccesLayer
{
    class UserDAO
    {
        public static User GetUser(string nombre, string contraseña)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            User usu = new User();
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Usuarios WHERE Usuario = @nombre and Password = @contra";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contra", contraseña);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataReader dataRead = cmd.ExecuteReader();
                if (dataRead != null && dataRead.Read())
                {
                    usu.CodUsu = (dataRead["IdUsuario"].ToString());
                    usu.nameUser = dataRead["Usuario"].ToString();
                    usu.Password = dataRead["Password"].ToString();
                    usu.Perfil = int.Parse(dataRead["Perfil"].ToString());
                    usu.DniEmpleado = dataRead["dniEmpleado"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return usu;
        }
    } 
}