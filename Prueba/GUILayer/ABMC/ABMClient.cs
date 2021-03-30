using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba.Entities;
namespace Prueba.GUILayer.ABMC
{
    public partial class FrmABMClient : Form
    {
        public FrmABMClient()
        {
            InitializeComponent();
        }
        private void CleanField()
        {
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtCuit.Text = "";
            TxtAddress.Text = "";
            TxtNumberAddress.Text = "";
            TxtPhone.Text = "";
            TxtNumberDoc.Text = "";
            TxtMail.Text = "";


        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanField();
        }

        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            string name =TxtName.Text;
            string surname = TxtSurname.Text;
            string cuit = TxtCuit.Text;
            string address = TxtAddress.Text;
            string numberAddress =TxtNumberAddress.Text;
            string phone = TxtPhone.Text;
            string numberDocument = TxtNumberDoc.Text;
            string mail = TxtMail.Text;
            Client client = new Client(name, surname, phone, cuit, mail, address, numberAddress, numberDocument);
            MessageBox.Show("Nombre de la persona: " + client.NameClient + client.SurnameClient + client.DocumentClient,"Datos Cliente");
        }

        private void FrmABMClient_Load(object sender, EventArgs e)
        {
            CmbDistrict.Items.Add("Centro");
            CmbDistrict.Items.Add("Nva Cordoba");
            CmbDistrict.Items.Add("Alta Cordoba");
            CmbDistrict.Items.Add("Cofico");
            CmbTypeDoc.Items.Add("DNI");
            CmbTypeDoc.Items.Add("Libreta Civica");
            CmbTypeDoc.Items.Add("Pasaporte");
        }

       
    }
}
