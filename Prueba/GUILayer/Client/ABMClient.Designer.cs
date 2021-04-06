
namespace Prueba.GUILayer.ABMC
{
    partial class FrmABMClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABMClient));
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnSaveClient = new System.Windows.Forms.Button();
            this.TxtNumberDoc = new System.Windows.Forms.MaskedTextBox();
            this.TxtNumberAddress = new System.Windows.Forms.TextBox();
            this.LblAddressNumb = new System.Windows.Forms.Label();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.CmbTypeDoc = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblDistrict = new System.Windows.Forms.Label();
            this.LblDocument = new System.Windows.Forms.Label();
            this.LblTypeDoc = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblCuit = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(180, 305);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 23);
            this.BtnClean.TabIndex = 69;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnSaveClient
            // 
            this.BtnSaveClient.Location = new System.Drawing.Point(85, 305);
            this.BtnSaveClient.Name = "BtnSaveClient";
            this.BtnSaveClient.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveClient.TabIndex = 68;
            this.BtnSaveClient.Text = "Guardar";
            this.BtnSaveClient.UseVisualStyleBackColor = true;
            this.BtnSaveClient.Click += new System.EventHandler(this.BtnSaveClient_Click);
            // 
            // TxtNumberDoc
            // 
            this.TxtNumberDoc.Location = new System.Drawing.Point(155, 161);
            this.TxtNumberDoc.Mask = "99999999";
            this.TxtNumberDoc.Name = "TxtNumberDoc";
            this.TxtNumberDoc.Size = new System.Drawing.Size(100, 20);
            this.TxtNumberDoc.TabIndex = 64;
            this.TxtNumberDoc.Text = "41778402";
            this.TxtNumberDoc.ValidatingType = typeof(int);
            // 
            // TxtNumberAddress
            // 
            this.TxtNumberAddress.Location = new System.Drawing.Point(155, 213);
            this.TxtNumberAddress.Name = "TxtNumberAddress";
            this.TxtNumberAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtNumberAddress.TabIndex = 66;
            this.TxtNumberAddress.Text = "1948";
            // 
            // LblAddressNumb
            // 
            this.LblAddressNumb.AutoSize = true;
            this.LblAddressNumb.Location = new System.Drawing.Point(25, 218);
            this.LblAddressNumb.Name = "LblAddressNumb";
            this.LblAddressNumb.Size = new System.Drawing.Size(50, 13);
            this.LblAddressNumb.TabIndex = 66;
            this.LblAddressNumb.Text = "Numero: ";
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(154, 239);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(100, 21);
            this.CmbDistrict.TabIndex = 67;
            // 
            // CmbTypeDoc
            // 
            this.CmbTypeDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeDoc.FormattingEnabled = true;
            this.CmbTypeDoc.Location = new System.Drawing.Point(154, 134);
            this.CmbTypeDoc.Name = "CmbTypeDoc";
            this.CmbTypeDoc.Size = new System.Drawing.Size(100, 21);
            this.CmbTypeDoc.TabIndex = 63;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(154, 111);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(100, 20);
            this.TxtMail.TabIndex = 62;
            this.TxtMail.Text = "ramiroferrari8@gmail.com";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(154, 61);
            this.TxtPhone.Mask = "(999)000-0000";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(100, 20);
            this.TxtPhone.TabIndex = 60;
            this.TxtPhone.Text = "3513768883";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(154, 187);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(100, 20);
            this.TxtAddress.TabIndex = 65;
            this.TxtAddress.Text = "Maria Curie ";
            // 
            // TxtCuit
            // 
            this.TxtCuit.Location = new System.Drawing.Point(154, 87);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(100, 20);
            this.TxtCuit.TabIndex = 61;
            this.TxtCuit.Text = "20-41778402-1";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(154, 35);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtSurname.TabIndex = 59;
            this.TxtSurname.Text = "Ferrari";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(154, 9);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 58;
            this.TxtName.Text = "Ramiro";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(25, 194);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(55, 13);
            this.LblAddress.TabIndex = 57;
            this.LblAddress.Text = "Domicilio: ";
            // 
            // LblDistrict
            // 
            this.LblDistrict.AutoSize = true;
            this.LblDistrict.Location = new System.Drawing.Point(25, 239);
            this.LblDistrict.Name = "LblDistrict";
            this.LblDistrict.Size = new System.Drawing.Size(40, 13);
            this.LblDistrict.TabIndex = 56;
            this.LblDistrict.Text = "Barrio: ";
            // 
            // LblDocument
            // 
            this.LblDocument.AutoSize = true;
            this.LblDocument.Location = new System.Drawing.Point(25, 168);
            this.LblDocument.Name = "LblDocument";
            this.LblDocument.Size = new System.Drawing.Size(123, 13);
            this.LblDocument.TabIndex = 55;
            this.LblDocument.Text = "Numero de Documento: ";
            // 
            // LblTypeDoc
            // 
            this.LblTypeDoc.AutoSize = true;
            this.LblTypeDoc.Location = new System.Drawing.Point(25, 142);
            this.LblTypeDoc.Name = "LblTypeDoc";
            this.LblTypeDoc.Size = new System.Drawing.Size(107, 13);
            this.LblTypeDoc.TabIndex = 54;
            this.LblTypeDoc.Text = "Tipo de Documento: ";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(25, 118);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(32, 13);
            this.LblMail.TabIndex = 53;
            this.LblMail.Text = "Mail: ";
            // 
            // LblCuit
            // 
            this.LblCuit.AutoSize = true;
            this.LblCuit.Location = new System.Drawing.Point(25, 94);
            this.LblCuit.Name = "LblCuit";
            this.LblCuit.Size = new System.Drawing.Size(38, 13);
            this.LblCuit.TabIndex = 52;
            this.LblCuit.Text = "CUIT: ";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(25, 70);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(55, 13);
            this.LblPhone.TabIndex = 51;
            this.LblPhone.Text = "Telefono: ";
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(25, 44);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(50, 13);
            this.LblSurname.TabIndex = 50;
            this.LblSurname.Text = "Apellido: ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(25, 18);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 13);
            this.LblName.TabIndex = 49;
            this.LblName.Text = "Nombre";
            // 
            // FrmABMClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 351);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnSaveClient);
            this.Controls.Add(this.TxtNumberDoc);
            this.Controls.Add(this.TxtNumberAddress);
            this.Controls.Add(this.LblAddressNumb);
            this.Controls.Add(this.CmbDistrict);
            this.Controls.Add(this.CmbTypeDoc);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblDistrict);
            this.Controls.Add(this.LblDocument);
            this.Controls.Add(this.LblTypeDoc);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblCuit);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmABMClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMClient";
            this.Load += new System.EventHandler(this.FrmABMClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnSaveClient;
        private System.Windows.Forms.MaskedTextBox TxtNumberDoc;
        private System.Windows.Forms.TextBox TxtNumberAddress;
        private System.Windows.Forms.Label LblAddressNumb;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.ComboBox CmbTypeDoc;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtCuit;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblDistrict;
        private System.Windows.Forms.Label LblDocument;
        private System.Windows.Forms.Label LblTypeDoc;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblCuit;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblName;
    }
}