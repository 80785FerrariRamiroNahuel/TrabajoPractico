using System;
using System.Drawing;
using System.Windows.Forms;
using Prueba.Entities;
using Prueba.GUILayer;
using Prueba.DataAccesLayer;
using System.Data.SqlClient;
using System.Data;
using Prueba.BusinessLayer;
namespace Prueba
{
    public partial class FrmLogin : Form
    {
        private readonly UserService userService;
        public FrmLogin()
        {
            InitializeComponent();
            userService = new UserService();
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
            DialogResult dialogResult = MessageBox.Show("Esta Seguro", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {



            if (TxtUser.Text.Equals("Usuario") || TxtPassword.Text.Equals("Contraseña") || TxtUser.Text.Equals("") || TxtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUser.Focus();


            }
            else
            {
                var usr = userService.ValidateUser(TxtUser.Text, TxtPassword.Text);
                if (usr != null)
                {
                    MessageBox.Show("Usuario Logeado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrincipal principal = new FrmPrincipal(usr);
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Ingrese los Datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtUser.Focus();
                }
                


            }


        }

        public void LimpiarCampos()
        {
            TxtUser.Text = "";
            TxtPassword.Text = "";
        }
    }
}
