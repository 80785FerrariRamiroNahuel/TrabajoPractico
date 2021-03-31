using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba.GUILayer.ABMC;

namespace Prueba.GUILayer
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string user)
        {
            InitializeComponent();


        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClient Client = new FrmClient();
            Client.Show();
            
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
            Image prueba = Image.FromFile(@"Images\" + imageNumber + ".jpg");
            SlidePic.Image = prueba;
            imageNumber++;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();

           
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
