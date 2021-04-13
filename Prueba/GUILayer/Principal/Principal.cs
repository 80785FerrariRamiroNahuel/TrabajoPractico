using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Prueba.Entities;
using Prueba.BusinessLayer;
using Prueba.GUILayer.ABMC;
using Prueba.GUILayer.Pucharses;
using Prueba.GUILayer.Report;
using Prueba.GUILayer.Stock;
using Prueba.GUILayer.Sales;
using Prueba.GUILayer.Employee;

namespace Prueba.GUILayer
{
    public partial class FrmPrincipal : Form
    {
        private User user;
        private void ValidateUserPerfil()
        {
            if (user.Perfil ==  2)
            {
                BtnClient.Enabled = false;
                BtnEmployee.Enabled = false;
                BtnPurchases.Enabled = false;
                BtnReport.Enabled = false;

            }
        }
        public FrmPrincipal(User user)
        {
            InitializeComponent();
            this.user = user;
            ValidateUserPerfil();
            PnlPrueba.Visible = false;
        }
      
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta Seguro", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            Image prueba = Image.FromFile(@"..\..\Pictures\Slide\" + imageNumber + ".jpg");
            SlidePic.Image = prueba;
            imageNumber++;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

           
        }
        public void AbrirFormInPanel1(object formHijo)
        {
            if (this.PnlPrueba.Controls.Count > 0)
                this.PnlPrueba.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PnlPrueba.Controls.Add(fh);
            this.PnlPrueba.Tag = fh;
            fh.Show();
        }
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            PnlPrueba.Visible = true;
            FrmClient Client = new FrmClient();
            AbrirFormInPanel1(Client);
            //Client.ShowDialog();
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            FrmSales Sales = new FrmSales();
            Sales.ShowDialog();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            FrmStock Stock = new FrmStock();
            Stock.ShowDialog();
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            FrmPucharses Pucharses = new FrmPucharses();
            Pucharses.ShowDialog();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee Employee = new FrmEmployee();
            Employee.ShowDialog();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmReport Report = new FrmReport();
            Report.ShowDialog();
        }
    }
}
