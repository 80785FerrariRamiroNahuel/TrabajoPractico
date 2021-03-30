using System;
using System.Drawing;
using System.Windows.Forms;
using Prueba.Entities;
using Prueba.GUILayer;
using Prueba.DataAccesLayer;
using System.Data.SqlClient;
using System.Data;

namespace Prueba
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            TxtUser.ForeColor = SystemColors.ControlText;
            TxtUser.Text = "";

        }
        private void TxtUser_Leave(object sender, EventArgs e)
        {

            if (TxtUser.Text.Equals(""))
            {
                TxtUser.ForeColor = SystemColors.InactiveCaption;
                TxtUser.Text = "Usuario";
            }

        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.ForeColor = SystemColors.ControlText;
            TxtPassword.Text = "";
            TxtPassword.UseSystemPasswordChar = true;
        }
        private void TxtPassword_Leave(object sender, EventArgs e)
        {

            if (TxtPassword.Text.Equals(""))
            {
                TxtPassword.ForeColor = SystemColors.InactiveCaption;
                TxtPassword.Text = "Contraseña";
                TxtPassword.UseSystemPasswordChar = false;
            }

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta Seguro", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            User user = new User(TxtUser.Text, TxtPassword.Text);
            string usuCorrecto = "ramiro";
            string passCorrecta = "123";
            
            if (TxtUser.Text.Equals("Usuario") || TxtPassword.Text.Equals("Contraseña") || TxtUser.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUser.Focus();


            }
            else if(TxtUser.Text.Equals(usuCorrecto) && TxtPassword.Text.Equals(passCorrecta))
            {
                MessageBox.Show("Usuario Logeado!", "Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmPrincipal principal = new FrmPrincipal(TxtUser.Text);
                principal.Show();
                this.Hide();
                
                

            }
            else
            {
                MessageBox.Show("Ingrese los Datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUser.Focus();
            }
        }

        private bool ValidateUser(string nameUser,string passUser)
        {
            bool flagResult = false;
            SqlCommand cmd = new SqlCommand();
            string query = "SELECT * FROM User WHERE Usuario like '"+nameUser+"'AND Password like '"+passUser+"'";
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            var cn = ConnectionBD.GetInstance();
            


            return flagResult;
        }

        private void LblBrand1_Click(object sender, EventArgs e)
        {

        }
    }
}

