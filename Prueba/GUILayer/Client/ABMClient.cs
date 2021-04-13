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
            if (TxtName.Text != "")
            {
                if (TxtSurname.Text != "")
                {
                    if (TxtCuit.Text != "")
                    {
                        if (TxtAddress.Text != "")
                        {
                            if (TxtNumberAddress.Text != "")
                            {
                                if (TxtNumberDoc.Text != "")
                                {
                                    string name = TxtName.Text;
                                    string surname = TxtSurname.Text;
                                    string phone = TxtPhone.Text;
                                    string cuit = TxtCuit.Text;
                                    string mail = TxtMail.Text;
                                    string tipoDocumento = CmbTypeDoc.GetItemText(CmbTypeDoc.SelectedItem);
                                    string numberDocument = TxtNumberDoc.Text;
                                    string address = TxtAddress.Text;
                                    string numberAddress = TxtNumberAddress.Text;
                                    string district = CmbDistrict.GetItemText(CmbDistrict.SelectedItem);
                                    Client client = new Client(name, surname, phone, cuit, mail, tipoDocumento, numberDocument, address, numberAddress, district);
                                    AddClient(client);

                                }
                                else
                                {
                                    MessageBox.Show("ingrese un numero de Documento");
                                    TxtNumberDoc.Focus();
                                }


                            }
                            else
                            {
                                MessageBox.Show("ingrese un Numero de direccion");
                                TxtNumberAddress.Focus();
                            }


                        }
                        else
                        {
                            MessageBox.Show("ingrese una Direccion");
                            TxtAddress.Focus();
                        }



                    }
                    else
                    {
                        MessageBox.Show("ingrese un Cuit");
                        TxtCuit.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("ingrese un Apellido");
                    TxtSurname.Focus();
                }


            }
            else
            {
                MessageBox.Show("ingrese un nombre");
                TxtName.Focus();
            }

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
