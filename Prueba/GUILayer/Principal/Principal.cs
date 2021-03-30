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
            SlidePic.ImageLocation =@"..\Images\2.jpg";

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
        private string prueba = "a";
        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            //prueba = string.Format(@"\Images\{0}.jpg", imageNumber);
            
            imageNumber++;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LoadNextImage();
            //MessageBox.Show(prueba);
           
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
